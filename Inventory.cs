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

        public void delete(string target)
        {
            if (this.mylist == null) throw new Exception("List not made");

            this.mylist.RemoveAll((Product p) => { return p.Name == target; });
        }



        public (bool, Product?) found(string target)
        {
            if (this.mylist == null) throw new Exception("List not made");
            foreach (Product a in this.mylist)
            {
                if (a.Name == target)
                {
                    return (true, a);
                }
            }
            return (false, null);
        }

        public void editQuantity(Product a, int quantity)
        {
            a.Quantity = quantity;
        }

        public void editPrice(Product a, int price)
        {
            a.Price = price;
        }

        public void editName(Product a, string name)
        {
            a.Name = name;
        }



    }
}
