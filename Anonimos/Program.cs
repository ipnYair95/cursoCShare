namespace Anonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hector = new
            {
                Name = "Hector",
                Country = "Mexico"
            };

            Console.WriteLine($"{hector.Name} {hector.Country} ");

            var cervezas = new[]
            {
                new { Name = "red", Brand = "delirum" },
                new { Name = "London", Brand = "Fullers" }
            };

            foreach ( var c in cervezas)
            {
                Console.WriteLine($"cerveza: {c.Name} brand: {c.Brand}");
            }

        }
    }
}