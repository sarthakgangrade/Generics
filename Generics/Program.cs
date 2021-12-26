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
             Console.WriteLine("Enter the First number:");
             int f = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the second number:");
             int s = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the third number:");
             int t = Convert.ToInt32(Console.ReadLine());

            //calling maxMethod()
            GenericsClass<int> genericMethod = new GenericsClass<int>(f, s, t);
            genericMethod.FindMax(f, s, t);

            Console.WriteLine("Enter the First float number:");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the second float number:");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the third float number:");
            float c = Convert.ToSingle(Console.ReadLine());

            //passing float values to maxMethod()
            GenericsClass<float> genericMethod1 = new GenericsClass<float>(a, b, c);
            genericMethod1.FindMax(a, b, c);

            Console.WriteLine("Enter the First string:");
            string x = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the second string:");
            string y = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the third string:");
            string z = Convert.ToString(Console.ReadLine());

            
            
            //passing string values to maxMethod()
            GenericsClass<string> genericMethod2 = new GenericsClass<string>(x, y, z);
            genericMethod2.FindMax(x, y, z);

            Console.ReadLine();

        }
    }
}
