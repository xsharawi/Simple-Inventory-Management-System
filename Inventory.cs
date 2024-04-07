namespace excercise1
{
    public class Inventory
    {
        private List<Product> _products;

        public Inventory()
        {
            _products = new List<Product>();
        }

        public void addToList(Product a)
        {

            this._products.Add(a);
        }

        public override string ToString()
        {
            string ans = "";
            foreach (Product a in this._products)
            {
                ans += (a.ToString());
                ans += "\n";
            }

            return ans;
        }

        public void delete(string target)
        {

            this._products.RemoveAll(p => p.Name == target);
        }



        public (bool, Product?) Find(string target)
        {
            foreach (Product a in this._products)
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
