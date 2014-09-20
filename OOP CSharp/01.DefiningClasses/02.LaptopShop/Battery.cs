using System;
using System.Text;

namespace LaptopShop
{
    class Battery
    {
        private double hoursLife;
        private string description;

        public Battery(){}

        public Battery(string description = null)
        {
            this.Description = description;
        }

        public Battery(string description, double hoursLife)
            : this(description)
        {
            this.HoursLife = hoursLife;
        }

        public double HoursLife
        {
            get { return this.hoursLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The battery hours can't be negative!");
                }
                this.hoursLife = value;
            }
        }

        public string Description
        {

            get { return this.description; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The battery description can't be null or empty!");
                }
                this.description = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(this.description)) 
            {
                sb.Append(String.Format("Battery description: {0} ", this.description));
            }

            if (this.hoursLife > 0)
            {
                sb.Append(String.Format("Battery life hours: {0}", this.hoursLife));
            }

            return sb.ToString();
        }
    }
}
