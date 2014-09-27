using System;

namespace GenericList
{
    class GenericListTester
    {
        static void Main()
        {
            GenericList<String> list = new GenericList<String>(4);

            list.AddElement("a");
            list.AddElement("b");
            list.AddElement("c");
            list.AddElement("d");
            list.AddElement("e");

            Console.WriteLine("Contains 'b': {0}", list.Contains("b"));
            Console.WriteLine("Index of 'c': {0}", list.FindElement("c"));
            list.AddElement("BANANA"); /// Adding element 'BANANA'
            list.Insert("APPLE", 3); /// Inserting 'APPLE' at position 3
            list.Max(); /// Returns Max Element
            list.Min(); // Min element
            Console.WriteLine(list[0]);
            list.RemoveAt(1); // Removing element at pos 1
            Console.WriteLine(list);


            var versionAttribute = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), false)[0];
            Console.WriteLine("\n\nGenericList<T> Version: " + versionAttribute);
       
        }
    }
}
