using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods { 
    public static class StringExtentions
    {
        public static int WordsCount(this String str)
        {
            return str.Split(new char[] { ' ','.','?','\t','\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static string Capitalize(this String str)
        {
            string first = str[0].ToString().ToUpper();
            return first + str.Substring(1);
        }
        public static void Decapitalize(this String str)
        {
            ///this does not work!!!!
            string first = str[0].ToString().ToLower();
            str = first + str.Substring(1);
        }
        public static string Titlize(this String title)
        {
            string [] first = title.Split(" ");
            List<string> articals = new List<string>
            {
                "a",
                "an",
                "the",

            };
            List<string> line = new List<string>(title.Split(" "));
            if (articals.Contains(first[0].ToLower()))
            {
              

                string parts = line[0];
                line.RemoveAt(0);
                line.Add(",");
                line.Add(parts);
                parts = line[0];
                while (articals.Contains(parts.ToLower()))
                {
                   
                    line.RemoveAt(0);
        
                    line.Add(parts);
                    parts = line[0];
                }
               
            }
            string b = "";
            foreach(string s in line)
            {
                b = b + " " + s;
            }
            return b;
        }
    }
}
