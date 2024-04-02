using NProduct;

namespace NInventory
{
    public class Inventory
    {
        private List<Product>? mylist;
        public Inventory()
        {
            mylist = new List<Product>();
        }

        public void addToList(Product a)
        {
            if (this.mylist == null) throw new Exception("List not made");

            this.mylist.Add(a);
        }


    }
}
