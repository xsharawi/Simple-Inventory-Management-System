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

        public override string ToString()
        {
            if (this.mylist == null) throw new Exception("List not made");
            string ans = "";
            foreach (Product a in this.mylist)
            {
                ans += (a.ToString());
                ans += "\n";
            }

            return ans;
        }


    }
}
