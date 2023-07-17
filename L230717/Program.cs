using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L230717
{
    internal class Program
    {
        static void swap(ref int x,ref int y)
        {

            int c = 0;
            c = y;
            x = y;
            x = c;

        }

        //sum, avg 

        static void Calculate(int a, int b, out int sum, out float avg)
        {
            sum = a + b;
            avg = (float)sum / 2.0f;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            swap(ref a, ref b);

            int c = 10;
            int d = 20;
         
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(c);
            Console.WriteLine(d);


            int sum = 0;
            float avg = 0;
            Calculate(a, b, out sum, out avg);

            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }

    }
}
