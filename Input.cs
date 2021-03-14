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
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine(); // Esperamos a la entrada del usuario poniendo la misma en esa variable
            Console.WriteLine("Hello {0}", yourName);

            //Readline por defecto recibe String, si quiero manejar otros tipos de datos..
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);

            //Convert => ToInt16, ToInt32, ToInt64, ToBoolean, ToDouble
        }
    }
}