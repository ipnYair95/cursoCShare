
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer(){ Name="Corona", Country="Mexico" },
                new Beer(){ Name="Delirum", Country="Belgica" },
                new Beer(){ Name="Erdinger", Country="Alemania" },
            };

            var countries = new List<Country>()
            {
               new Country(){ Name="Mexico",Continent="America" },
               new Country(){ Name="Belgica",Continent="Europa" },
               new Country(){ Name="Alemania",Continent="Europa" },
            };

            foreach ( var beer in beers )
            {
                Console.WriteLine( beer.ToString() );
            }

            Console.WriteLine("------------");

            //select
            var beersName = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                                Fixed = 1
                            };

            foreach (var beer in beersName)
            {
                Console.WriteLine($"{beer.Name} {beer.Letters} {beer.Fixed}");
            }

            Console.WriteLine("------------");

            var beersNameReal = from b in beersName
                                select new
                                {
                                    Name = b.Name
                                };

            foreach (var beer in beersNameReal)
            {
                Console.WriteLine($"{beer.Name}");
            }

            Console.WriteLine("------------");

            var beersMexico = from b in beers
                              where b.Country == "Mexico"
                              || b.Country == "Alemania"
                              select b;

            foreach (var beer in beersMexico)
            {
                Console.WriteLine(beer.ToString());
            }

            Console.WriteLine("------------");

            var orderedBeers = from b in beers
                               orderby b.Country
                               select b;

            foreach (var beer in orderedBeers)
            {
                Console.WriteLine(beer.ToString());
            }

            //union
            Console.WriteLine("------------");
            var beersWithContinent = from beer in beers
                                     join country in countries
                                     on beer.Country equals country.Name
                                     select new
                                     {
                                         Name = beer.Name,
                                         Country = beer.Country,
                                         Continent = country.Continent
                                     };

            foreach (var beer in beersWithContinent)
            {
                Console.WriteLine($"{beer.Name} {beer.Country} {beer.Continent}");
            }
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Country: {Country}";
        }

    }

    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }

    }

}