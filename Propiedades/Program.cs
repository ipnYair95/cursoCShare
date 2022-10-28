namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100, DateTime.Now);
            sale1.Total = 150;
            Console.WriteLine( sale1.Total );
        }
    }

    class Sale
    {
        private int total;
        private DateTime date;

        public string Date
        {
            get { return date.ToLongDateString(); }
        }

        public int Total
        {
            get { return total; }
            set 
            {
                if (value < 0)
                    value = 0;

                total = value;
            }
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }

        public void Show()
        {
            Console.WriteLine("hola soy una venta");
        }
    }
}