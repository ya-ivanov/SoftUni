using System;
using System.Text;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string screen;
        private string cpu;
        private string ram;
        private string gpu;
        private string hdd;
        private double price;
        private Battery battery;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, double price, string manufacturer = null, string screen = null, string cpu = null, string ram = null, string gpu = null, string hdd = null, Battery battery = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Screen = screen;
            this.CPU = cpu;
            this.RAM = ram;
            this.CPU = gpu;
            this.HDD = hdd;
            this.Battery = battery;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The model can't be empty");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The manufacturer can't be empty");
                }
                this.manufacturer = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The screen details can't be empty");
                }
                this.screen = value;
            }
        }

        public string CPU
        {
            get { return this.cpu; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The CPU details can't be empty");
                }
                this.cpu = value;
            }
        }

        public string GPU
        {
            get { return this.gpu; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The GPU details can't be empty");
                }
                this.gpu = value;
            }
        }

        public string RAM
        {
            get { return this.ram; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The RAM details can't be empty");
                }
                this.ram = value;
            }
        }

        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The HDD details can't be empty");
                }
                this.hdd = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price can't be 0 or negative number!");
                }
                this.price = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(this.Model == null ? "" : String.Format("Model: {0}\n", this.Model));
            sb.Append(this.Price < 0 ? "" : String.Format("Price: {0}\n", this.Price));
            sb.Append(this.Manufacturer == null ? "" : String.Format("Manufacturer: {0}\n", this.Manufacturer));
            sb.Append(this.Screen == null ? "" : String.Format("Screen Details: {0}\n", this.Screen));
            sb.Append(this.CPU == null ? "" : String.Format("CPU Type: {0}\n", this.CPU));
            sb.Append(this.RAM == null ? "" : String.Format("RAM details: {0}\n", this.RAM));
            sb.Append(this.GPU == null ? "" : String.Format("GPU Type: {0}\n", this.GPU));
            sb.Append(this.HDD == null ? "" : String.Format("HDD details: {0}\n", this.HDD));
            sb.Append(this.Battery == null ? "" : String.Format("Battery details: {0}\n", this.Battery));

            return sb.ToString();
        }


    }
}
