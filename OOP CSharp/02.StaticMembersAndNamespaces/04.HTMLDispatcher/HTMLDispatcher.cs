using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcherMain
{
    public static class HTMLDispatcher
    {
        public static string CreateImage(string imgSource, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.addAttribute("src", imgSource);
            img.addAttribute("alt", alt);
            img.addAttribute("title", title);
            return img.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder img = new ElementBuilder("a");
            img.addAttribute("href", url);
            img.addAttribute("title", title);
            img.addContent(text);
            return img.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder img = new ElementBuilder("input");
            img.addAttribute("type", type);
            img.addAttribute("name", name);
            img.addAttribute("value", value);
            return img.ToString();
        }
    }
}
