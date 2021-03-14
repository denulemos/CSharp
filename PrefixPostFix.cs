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
            // Prefix => Incrementa el valor y despues sigue con la expresion
            int x = 3;
            int y = ++x;
            Console.WriteLine(x+" "+y); //4 4 

            // PostFix => Evalua la expresion y despues incrementa
             x = 3;
             y = x++;
            Console.WriteLine(x+" "+y); // 4 3
        }
    }
}