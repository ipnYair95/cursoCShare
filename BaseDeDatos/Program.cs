namespace BaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                BeerDB beerDb = new BeerDB(@"EDGARMARIN640G4", "CSharpDb", "", "");
                bool again = true;
                int op = 0;

                do
                {
                    ShowMenu();
                    Console.WriteLine("Elige una opcion: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Show(beerDb);
                            break;
                        case 2:
                            Add(beerDb);
                            break;
                        case 3:
                            Edit(beerDb);
                            break;
                        case 4:
                            Delete(beerDb);
                            break;
                        case 5:
                            again = false;
                            break;
                    }


                } while (again);


            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo establecer conn");
                Console.WriteLine(e.Message);
            }

        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n ------------- MENU ------------- \n");
            Console.WriteLine("1.- Mostrar");
            Console.WriteLine("2.- Agregar");
            Console.WriteLine("3.- Editar");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("5.- Salir");

        }

        public static void Show(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Cerverzas de la base de datos");
            List<Beer> beers = beerDB.GetAll();

            foreach (var beer in beers)
            {
                Console.WriteLine($"Id: {beer.Id} Nombre: {beer.Name}");
            }

        }

        public static void Add(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el Id de la marca: ");
            int brandId = int.Parse(Console.ReadLine());
            Beer beer = new Beer(name, brandId);
            beerDB.Add(beer);
        }

        public static void Edit(BeerDB beerDb)
        {
            Console.Clear();
            Show(beerDb);
            Console.WriteLine("Editar cerveza");
            Console.WriteLine("Escribe el id de cerveza a editar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDb.Get(id);

            if (beer != null)
            {
                Console.WriteLine("Escribe el nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el id de la marca: ");
                int brandId = int.Parse(Console.ReadLine());
                beer.Name = name;
                beer.BrandId = brandId;
                beerDb.Edit(beer);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }


        }

        public static void Delete(BeerDB beerDb)
        {
            Console.Clear();
            Show(beerDb);
            Console.WriteLine("Eliminar cerveza");
            Console.WriteLine("Escribe el id de cerveza a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDb.Get(id);

            if (beer != null)
            {
                beerDb.Delete(id);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }

        }
    }
}