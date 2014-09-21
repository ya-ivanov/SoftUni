using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Paths
{
    public static class Storage
    {
        public static void SavePath(string fileName, Path3D path) // Write the Path3D object to a text file
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("UTF-8")))
                {
                    sw.WriteLine(path.ToString());
                }
            }
            catch (Exception)
            {
                throw new Exception("Error white writing to file.");
            }
        } 

        public static string ReadPath(string fileName) // Read the text from a file, and return it as a result
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding("UTF-8")))
                {
                    sb.Append(sr.ReadToEnd());
                }
            }
            catch (Exception)
            {
                throw new Exception("Error reading from file. Maybe it doesn't exist?");
            }

            return sb.ToString();
        }

        public static Path3D ToPath3D(string text) //The user uses the ReadPath result to create Point3D objects and with them, create Path3D obj 
        {
            Path3D path = new Path3D();
            Regex rgx = new Regex(@"Point \[X:(.*?),\sY:(.*?),\sZ:(.*?)]");
            
            foreach (Match m in Regex.Matches(text, @"Point \[X:(.*?),\sY:(.*?),\sZ:(.*?)]"))
            {
                path.addPoint(new Point3D(Double.Parse(m.Groups[1].Value), Double.Parse(m.Groups[2].Value), Double.Parse(m.Groups[3].Value)));
            }
            
            return path;
        }
    }
}
