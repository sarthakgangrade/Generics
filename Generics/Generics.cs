using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericsClass<T> where T : IComparable//extending the icomarable class 
    {
        public T first, second, third;

        //creating class constructor
        public GenericsClass(T first, T second, T third)
        {
            //this will point to current object value
            this.first = first;
            this.second = second;
            this.third = third;

        }

        //creating a generic method findMax() to find the max number for integer, float and string
        public T FindMax(T first, T second, T third)
        {
            //using inbuilt compareto() method for checking the max of three numbers
            //condition to check first is greater
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("first {0} is greater", first);
            }
            //condition to check second is greater
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("second  {0} is greater", second);//if second is greater
            }
            //condition to check third is greater
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("third {0} is greater", third);
            }
            else
            {
                //else two or more than two numbers are equal
                Console.WriteLine("two or more are equal");
            }
            return default;
        }
    }
}
