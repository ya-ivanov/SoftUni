using System;

namespace CustomerProgram
{
    public class Payment
    {
        private string productName;
        private decimal price;

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("The product name can't be null of empty.");
                this.productName = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The product price must be a positive number.");
                this.price = value;
            }
        }

        public Payment(string name, decimal price)
        {
            this.ProductName = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("Product name: {0}, Price: {1}", this.productName, this.price);
        }
    }
}
