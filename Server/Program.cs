using Microsoft.EntityFrameworkCore;
using RentABikeV3.Server.Data;
using RentABikeV3.Server.Interfaces;
using RentABikeV3.Server.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RentABikeV3.Server.Data;
using RentABikeV3.Server.Controllers;
using RentABikeV3.Server.Interfaces;
using RentABikeV3.Server.Repository;

namespace RentABikeV3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IBikeRepository, BikeRepository>();
            builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<RentABikeV3ServerContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("RentABikeV3ServerContext") ?? throw new InvalidOperationException("Connection string 'RentABikeV3ServerContext' not found.")));
            builder.Services.AddRazorPages();

            var app = builder.Build();
            app.UseCors("AllowAnyOrigin");
            app.UseCors();
            // Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();

            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            };
            app.UseCors("AllowAnyOrigin");
            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor API V1");
            });

            app.UseRouting();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");


            app.Run();
        }
    }
}