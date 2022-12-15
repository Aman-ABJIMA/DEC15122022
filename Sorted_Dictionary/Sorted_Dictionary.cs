using System;
namespace MY_Dictonary
{
    public class Enumerating_Dictionary
    {
        public static void Main(string[] args)
        {
            SortedDictionary<int, string> dictonary = new SortedDictionary<int, string>
            {
                { 11110, "Jhansi"},
                { 21110, "Jaipur"},
                { 31110, "Lucknow"},
                { 41110, "Orai"},
                { 11109, "Gowalior"}
            };
            //or
            dictonary[51110] = "Udaipur";


            //Enumerating of Dictionary

            //Method:01

            foreach (var i in dictonary) { Console.WriteLine(i); }

            Console.WriteLine("\n");

        }
    }
}