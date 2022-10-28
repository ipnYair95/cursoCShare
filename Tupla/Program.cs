namespace Tupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) product = (1, "cerveza");
            Console.WriteLine($"{product.id} {product.name}");

            product.name = "cerveza porter";
            Console.WriteLine($"{product.id} {product.name}");

            var person = (1, "Hector", true);
            Console.WriteLine($"persona {person.Item1} {person.Item2} {person.Item3}");

            var people = new[]
            {
                (1,"Hector"),
                (2,"Juan"),
                (3,"Doe"),
            };

            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            (int Id, string Name)[] people2 = new[]
            {
                (1,"Hector"),
                (2,"Juan"),
                (3,"Doe"),
            };

            foreach (var p in people2)
            {
                Console.WriteLine($"{p.Id} {p.Name}");
            }

            var cityInfo = getLocation();
            Console.WriteLine($" Lat: {cityInfo.lat}, Lng: {cityInfo.lng}, Nombre: {cityInfo.name} ");

            var (_, lng, _) = getLocation();
            Console.WriteLine(lng);

        }

        public static (float lat, float lng, string name) getLocation()
        {
            float lat = 124.23f;
            float lng = -234.4f;
            string name = "CDMX";

            return (lat, lng, name);
        }
    }
}