
namespace excercise1
{
    public class Product
    {
        public string Name { set; get; } = String.Empty;

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


        public override string ToString()
        {
            return $"Product name: {Name}, Product price: {Price}, Product quantity: {Quantity}";
        }

    }
}
