using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write the same line");
            Console.WriteLine("This will \n wrap to next line"); //backslash is also called an escape character
            Console.WriteLine("This will \" print out the quotation mark");

            string firstName = "Nokwanda";
            string lastName = "Khubisa";

            //concatination
            Console.WriteLine(firstName + " " + lastName);

            //functions with strings
            Console.WriteLine(lastName.Length);

            //methods on strings
            Console.WriteLine(firstName.ToUpper());

            //method with a parameter e.g the contains(), it's case sensitive
            Console.WriteLine(lastName.Contains("Fu"));

            //access characters using index 
            Console.WriteLine(firstName[0]);

            //indexOf will tell you if the value is there and at what position
            Console.WriteLine("index of a is: ");
            Console.WriteLine(lastName.IndexOf('a')); //can use double quotes too

            //Substring, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));

            //you can also give index and length i.e how many chars you wanna grab
            Console.WriteLine(firstName.Substring(1,2));

            Console.Read();


        }
    }
}
