using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(radius*radius*pi);
            
        }
    }
}