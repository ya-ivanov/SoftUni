using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLDispatcherMain
{
    public class ElementBuilder
    {
        private List<String> attributes = new List<string>();
        private string content;
        private string name;

        public ElementBuilder(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("The element name can't be null or empty");
                this.name = value;
            }
        }

        public string Content
        {
            get { return this.content; }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("The elements' content can't be null or empty!");
                this.content = value;
            }
        }

        public void addAttribute(string attribute, string value)
        {
            if (value == null || attribute == null || attribute == "" || value == "")
                throw new ArgumentException("Invalid data passed, when adding new attribute!");
            this.attributes.Add(String.Format("{0}\"{1}\"", attribute, value));
        }

        public void addContent(string content)
        {
            this.Content += content;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("<{0}", this.name));

            if (this.attributes.Count > 0)
            {
                sb.Append(" ");
                for (int i = 0; i < this.attributes.Count; i++)
                {
                    if (i == this.attributes.Count - 1)
                        sb.Append(this.attributes[i]);
                    else
                        sb.Append(this.attributes[i] + " ");
                }
            }
            sb.Append(">");
            sb.Append(this.content != null || this.content != "" ? this.content : "");
            sb.Append(String.Format("</{0}>", this.name));
            return sb.ToString();
        }

        public static string operator * (ElementBuilder element, int times)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < times; i++)
                sb.Append(element.ToString());
            return sb.ToString();
        }

    }
}
