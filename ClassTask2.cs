using System.Reflection;
using System.Xml.Schema;

namespace class_task 
{
    internal class Program
    {
        static void Main(string[] args)
        {   ////Task2
            Notebook notebook = new Notebook("Apple","MacBook Pro 16",1,true,8500, 1 ,16);
            notebook.Sale();
            notebook.ShowFullData();

        }
    }

    class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

        public Product(string Name, string Description, int Count, bool IsStock, double price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Count = Count;
            this.IsStock = IsStock;
            this.Price = price;
        }


    }

    class Notebook : Product
    {
        public byte RAM;
        public int Storage;

        public Notebook(string Name, string Description, int Count, bool IsStock, double price, byte RAM, int Storege)
            : base(Name, Description, Count, IsStock, price)
        {
            this.RAM = RAM;
            this.Storage = Storege;
        }

        public void Sale()
        {
            if (IsStock == false)
            {
                Console.WriteLine("Mehsul Yoxdur");
            }
            else
            {
                Console.WriteLine("Mehsul Satisdadir...");
            }

        }


        public void ShowFullData()
        {
          
           
            Console.WriteLine($"NoteBook adi: {Name}, Descripton:{Description}, Count:{Count}, Stokda Varmi: {IsStock}, Qiymeti:{Price}, " +
            $"Ram:{RAM}, Hansi Magazadadir:{Storage} ");
            
        }



        public void GetFullData()
        {
            Console.WriteLine();
        }

    }

}


