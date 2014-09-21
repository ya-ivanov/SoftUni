using System;
using System.Collections.Generic;

namespace HTMLDispatcherMain
{
    public class HTMLDispatcherMain
    {
        static void Main()
        {
            /*ElementBuilder a = new ElementBuilder("a"); /// Create a element with some attributes
            a.addAttribute("id", "13");
            a.addAttribute("class", "new_link");
            a.addContent("Click here for more info...");
            Console.WriteLine(a.ToString());*/

            /*ElementBuilder li = new ElementBuilder("li"); // Create li element and demonstrate overloading the * operator
            li.addAttribute("class", "subject");
            Console.WriteLine(li*6);*/

            Console.WriteLine(HTMLDispatcher.CreateImage("http://someimg.com/img.png", "user avatar", "Avatar"));
            Console.WriteLine(HTMLDispatcher.CreateInput("submit", "submit_form", "Submit"));
            Console.WriteLine(HTMLDispatcher.CreateURL("http://google.com", "google", "Open Google"));
        }
    }   
}
