using System;
using System.Text;

namespace PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private float price;

        public Component(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, float price, string details = null)
            : this(name, price)
        {            
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The component name can't be empty!");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The component details can't be empty!");
                }
                this.details = value;
            }
        }

        public float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0) 
                {
                    throw new ArgumentOutOfRangeException("The component price can't be 0 or a negative number!");
                }
                this.price = value;
            }
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Name: {0}, Price: {1} BGN{2}", this.Name, Math.Round(this.Price, 2), this.Details != null ? ", Details: " + this.Details : ""));
            return sb.ToString();
        }

    }
}
