using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        

        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter the First number:");
             int f = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the second number:");
             int s = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the third number:");
             int t = Convert.ToInt32(Console.ReadLine());*/

            /*Console.WriteLine("Enter the First number:");
            float f = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float s = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            float t = Convert.ToSingle(Console.ReadLine());

            SimpleClass simple = new SimpleClass(f, s, t);
            simple.findMax();*/

            Console.WriteLine("Enter the First string:");
            string f = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the second string:");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the third string:");
            string t = Convert.ToString(Console.ReadLine());

            SimpleClass simple = new SimpleClass(f, s, t);
            simple.findMax();
        }
    }
}
