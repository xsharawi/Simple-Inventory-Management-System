
namespace NProduct
{
    public class Product
    {

        private string name = String.Empty;
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        private int price = 0;
        public int Price
        {
            set { this.price = value; }
            get { return this.price; }
        }


        private int quantity = 0;
        public int Quantity
        {
            set { this.quantity = value; }
            get { return this.quantity; }
        }



    }
}
