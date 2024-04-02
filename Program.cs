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
            String nameinput = Console.ReadLine();

            Console.WriteLine("Product price?");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product quantity?");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Product myProd = new Product();
            Product myProd2 = new Product();

            myProd.Name = nameinput;
            myProd.Price = (int)price;
            myProd.Quantity = (int)quantity;

            myProd2.Name = nameinput;
            myProd2.Price = (int)price;
            myProd2.Quantity = (int)quantity;


            var output = myProd.ToString();
            Console.WriteLine(output);

            myInverntory.addToList(myProd);
            myInverntory.addToList(myProd2);

            var inventoryoutput = myInverntory.ToString();

            Console.WriteLine("");
            Console.WriteLine(inventoryoutput);

            Console.WriteLine("Searchable name?");
            String searchable = Console.ReadLine();

            (bool, Product) myTup = myInverntory.found(searchable);
            if (myTup.Item1)
            {
                Console.WriteLine(myTup.Item2.ToString());
            }
            else
            {
                Console.WriteLine("item not found");
            }

            Console.WriteLine("delete name?");
            String del = Console.ReadLine();


            myInverntory.delete(del);

            inventoryoutput = myInverntory.ToString();

            Console.WriteLine("");
            Console.WriteLine(inventoryoutput);



        }
    }
}
