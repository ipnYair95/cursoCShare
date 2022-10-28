using System.Text.Json;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Cerveza",
                Brand = "Light"
            };

            //string json = "{ \"Name\": \"Cerveza\", \"Brand\": \"Light\" }";
            string json = JsonSerializer.Serialize(myBeer);
            Beer myBeer2 = JsonSerializer.Deserialize<Beer>(json);

            Beer[] beers = new Beer[]
            {
                new Beer(){Name = "Cerveza",Brand = "Light"},
                new Beer(){Name = "Cerveza2",Brand = "Light"},
            };
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

    }
}