using NProduct;
using NInventory;

namespace Managment
{
    class Program
    {
        static void Main(string[] args)
        {

            Inventory myInverntory = new Inventory();

            Console.WriteLine("Product name?");
            String? nameinput = Console.ReadLine();
            Console.WriteLine("Product price?");
            int? price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product quantity?");
            int? quantity = Convert.ToInt32(Console.ReadLine());

            Product myProd = new Product();

            myProd.Name = nameinput;
            myProd.Price = (int)price;
            myProd.Quantity = (int)quantity;

            var output = myProd.ToString();
            Console.WriteLine(output);
            myInverntory.addToList(myProd);

        }
    }
}
