using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using WebApplication2.Models;
using WebApplication2.Services.SuperHeroServices;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            this.superHeroService = superHeroService;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHero()
        {
            var result = superHeroService.GetAllHeroes();
            if (result is null) return NotFound();
            return Ok(result);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var result = superHeroService.GetSingleHero(id);
            if (result is null) return NotFound();
            return Ok(result);

        }
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var result = superHeroService.AddHero(hero);
            if (result is null) return NotFound();
            return Ok(result);

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero superHero)
        {
            var result = superHeroService.UpdateHero(id, superHero);
            if (result is null)
                return NotFound();
            return Ok(result);
        }
        [HttpDelete]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = superHeroService.DeleteHero(id);
            if (result is null) return NotFound();
            return Ok(result);
        }

    }
}
