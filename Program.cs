using NProduct;
using NInventory;

namespace Managment
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 9;
            Inventory myInverntory = new Inventory();
            while (choice != 6)
            {
                Console.Clear();
                Console.WriteLine("1) Add a product");
                Console.WriteLine("2) View all products");
                Console.WriteLine("3) Edit a product");
                Console.WriteLine("4) Delete a product");
                Console.WriteLine("5) Search for a product");
                Console.WriteLine("6) Exit");

                Console.WriteLine("Which choice do you want?");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {

                    Console.WriteLine("Product name?");
                    String nameinput = Console.ReadLine();

                    Console.WriteLine("Product price?");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Product quantity?");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Product myProd = new Product();

                    myProd.Name = nameinput;
                    myProd.Price = (int)price;
                    myProd.Quantity = (int)quantity;
                    myInverntory.addToList(myProd);
                }
                else if (choice == 2)
                {
                    var inventoryoutput = myInverntory.ToString();
                    Console.WriteLine(inventoryoutput);
                }
                else if (choice == 3)
                {
                }
                else if (choice == 4)
                {

                    Console.WriteLine("delete name?");
                    String del = Console.ReadLine();

                    myInverntory.delete(del);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Search name?");
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

                }




            }


        }
    }
}
