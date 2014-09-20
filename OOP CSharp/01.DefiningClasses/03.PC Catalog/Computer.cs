using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PCCatalog
{
    class Computer
    {
        private string name;
        private double price = 0;

        private List<Component> components;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
            foreach (Component component in components)
            { 
                this.price += (component.Price);
            }
        }

        public string Name
        {
            get { return this.name;  }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("The Computer name can't be empty!");
                }
                this.name = value;
            }
        }
        
        public List<Component> Components 
        {
            get 
            {
                return this.components;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("There must be at least one component in the computer!");
                }
                this.components = value;
            }
        }

        public void AddComponent(Component component) 
        {
            if (component != null)
                components.Add(component);
            else
                throw new ArgumentNullException("The component can't be null");
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}\n", this.name));
            sb.Append("Components: \n");

            foreach (Component component in this.components) 
            {
                sb.Append(component.ToString());
            }

            sb.Append(String.Format("Total Computer Price: {0} BGN\n", Math.Round(this.price, 2)));
            return sb.ToString();
        }

        public double Price { get { return this.price; } }
    }
}