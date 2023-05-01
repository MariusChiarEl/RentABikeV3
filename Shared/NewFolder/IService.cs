using WebApplication2.Models;

namespace WebApplication2.Services.SuperHeroServices
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        SuperHero? GetSingleHero(int id);
        List<SuperHero> AddHero(SuperHero newHero);
        List<SuperHero> DeleteHero(int id);
        List<SuperHero>? UpdateHero(int id, SuperHero superHero);
    }
}
