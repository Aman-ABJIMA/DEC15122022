using System;
namespace MY_Dictonary
{
    public class Add_elements_Into_the_Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dictonary = new Dictionary<int, string>
            {
                { 11110, "Jhansi"},
                { 21110, "Jaipur"},
                { 31110, "Lucknow"},
                { 41110, "Orai"},
                { 11109, "Gowalior"}
            };
                   //or
            dictonary[51110]= "Udaipur";

            //var key = dictonary[11111];// if element not found exception can be occures, to avoid Exception we use TryGetValue Method...
           
            Console.WriteLine("Enter Bus No:");
            var key=int.Parse(Console.ReadLine());
           
            var k = dictonary.TryGetValue(key, out var i);  //TryGetValue() :it will return Boolean Value
          
            if(k)
            {
                Console.WriteLine("Bus start from:{0}", i); 
            }
            else 
            { 
                Console.WriteLine("No Bus Available!!!");
            }


            //Lets See with ContainsKey() method: It will also checks the item is available or not, and return boolean value accordingly
            Console.WriteLine("Find Item Using ContainsKey() Method\n************************\nEnter Key:");

            var KEY = int.Parse(Console.ReadLine());

            var item = dictonary.ContainsKey(KEY);  //ContainsKey() :it will return Boolean Value

            if (item)
            {
                Console.WriteLine("Bus start from:{0}", dictonary[KEY]);
            }
            else
            {
                Console.WriteLine("No Bus Available!!!");
            }
            

        }
    }
}