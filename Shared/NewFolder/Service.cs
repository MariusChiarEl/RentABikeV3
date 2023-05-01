using WebApplication2.Models;

namespace WebApplication2.Services.SuperHeroServices
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>() {
            new SuperHero{Id=1,
                Name="Spider Man",
                FirstName="Peter",
                LastName="Parker",
                Place="New York" },
            new SuperHero{Id=2,
                Name="Iron Man",
                FirstName="Tony",
                LastName="Stark",
                Place="Malibu" }
            };

        public List<SuperHero> AddHero(SuperHero newHero)
        {
            superHeroes.Add(newHero);
            return superHeroes;
        }

        public List<SuperHero> DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null) return null;
            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHero> GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero? GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null) return null;
            return hero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero superHero)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null) return null;
            hero.Name = superHero.Name;
            hero.FirstName = superHero.FirstName;
            hero.LastName = superHero.LastName;
            hero.Place = superHero.Place;
            return superHeroes;
        }
    }
}