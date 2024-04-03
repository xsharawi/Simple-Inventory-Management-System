using NProduct;
using NInventory;

namespace Managment
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
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
                    var inventoryoutput = myInverntory.ToString();
                    Console.WriteLine(inventoryoutput);

                    Console.WriteLine("Type the name of the product you want to change: ");
                    String edit = Console.ReadLine();

                    (bool, Product) myTup = myInverntory.found(edit);
                    if (myTup.Item1)
                    {
                        int choice2 = 0;
                        while (choice2 != 4)
                        {
                            Console.WriteLine("Which do you want to update");
                            Console.WriteLine("1) Product name");
                            Console.WriteLine("2) Product price");
                            Console.WriteLine("3) Product quantity");
                            Console.WriteLine("4) Done editing");
                            Console.WriteLine("Which choice do you want?");
                            choice2 = Convert.ToInt32(Console.ReadLine());

                            if (choice2 == 1)
                            {
                                Console.WriteLine("Enter the new name:");
                                String newName = Console.ReadLine();
                                myInverntory.editName(myTup.Item2, newName);

                            }
                            else if (choice2 == 2)
                            {
                                Console.WriteLine("Enter the new price");
                                int newPrice = Convert.ToInt32(Console.ReadLine());
                                myInverntory.editPrice(myTup.Item2, newPrice);

                            }
                            else if (choice2 == 3)
                            {
                                Console.WriteLine("Enter the new quantity");
                                int newQuantity = Convert.ToInt32(Console.ReadLine());
                                myInverntory.editQuantity(myTup.Item2, newQuantity);

                            }
                        }



                    }
                    else
                    {
                        Console.WriteLine("item not found");
                    }



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

                if (choice != 6)
                {
                    Console.WriteLine("press any key to continue");
                    Console.Read();
                }

                if (choice == 6)
                {
                    Console.WriteLine("Thanks for using my little cli application");
                }




            }


        }
    }
}
