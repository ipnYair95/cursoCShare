using BD;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace EntityFrameworkSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DbContextOptionsBuilder<CSharpDbContext> optionsBuilder = new DbContextOptionsBuilder<CSharpDbContext>();

            optionsBuilder.UseSqlServer("Server=EDGARMARIN640G4; Database=CSharpDb; Trusted_Connection=True;");

            bool again = true;
            int op = 0;


            do
            {
                ShowMenu();
                Console.WriteLine("Elige una opción: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        Add(optionsBuilder);
                        break;
                    case 3:
                        Edit(optionsBuilder);
                        break;
                    case 4:
                        Delete(optionsBuilder);
                        break;
                    case 5:
                        again = false;
                        break;
                }

            } while (again); 


        }

        public static void Show(DbContextOptionsBuilder<CSharpDbContext> optionBuilder)
        {
            Console.Clear();
            Console.WriteLine("Cervezas en la base");
            using (var context = new CSharpDbContext(optionBuilder.Options))
            {
                List<Beer> beers = context.Beers.OrderBy(b => b.Brand).ToList();
                List<Beer> beers2 = (from b in context.Beers
                                     where b.BrandId == 2
                                     orderby b.Name
                                     select b).Include(b => b.Brand).ToList();

                Console.WriteLine("*********** normal ***********");

                foreach (var beer in beers)
                {
                    Console.WriteLine($"{beer.Id} {beer.Name} ");
                }

                Console.WriteLine("*********** con linq ***********");

                foreach (var beer in beers2)
                {
                    Console.WriteLine($"{beer.Id} {beer.Name} {beer.Brand.Name} ");
                }

            }
        }

        public static void Edit(DbContextOptionsBuilder<CSharpDbContext> optionBuilder)
        {
            Console.Clear();
            Show(optionBuilder);

            Console.WriteLine("Editar cerveza");
            Console.WriteLine("Escribe el id de cerveza: ");
            int id = int.Parse( Console.ReadLine() );             

            using ( var context = new CSharpDbContext(optionBuilder.Options) )
            {
                Beer beer = context.Beers.Find(id);

                if ( beer == null )
                {
                    Console.WriteLine("Cerverza no existente");
                    return;
                }

                Console.WriteLine("Escribe el nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el id de marca: ");
                int brandId = int.Parse( Console.ReadLine() );

                beer.Name = name;
                beer.BrandId = brandId;
                context.Entry(beer).State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public static void Add(DbContextOptionsBuilder<CSharpDbContext> optionBuilder)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de marca: ");
            int brandId = int.Parse(Console.ReadLine());

            using (var context = new CSharpDbContext(optionBuilder.Options))
            {
                Beer beer = new Beer()
                {
                    Name = name,
                    BrandId = brandId
                };
                context.Add(beer);
                context.SaveChanges();
            }
        }

        public static void Delete(DbContextOptionsBuilder<CSharpDbContext> optionBuilder)
        {
            Console.Clear();
            Show(optionBuilder);

            Console.WriteLine("Eliminar cerveza");
            Console.WriteLine("Escribe el id de cerveza: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new CSharpDbContext(optionBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);

                if ( beer == null )
                {
                    Console.WriteLine("No existe cerveza");
                    return;
                }

                context.Beers.Remove(beer);
                context.SaveChanges();
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

    }
}