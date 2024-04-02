using NProduct;
using NInventory;

namespace Managment
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product();
            a.Name = "hi";
            Console.WriteLine(a.Name);
        }
    }
}
