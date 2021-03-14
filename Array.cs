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
            //Separar valores de un array por guiones
           int[] ages = {30, 15, 20, 35};
           var s = String.Join(“-”, ages);
           Console.WriteLine(s);

           // Ordenar un array de numeros de forma descendente
           Array.sort(ages);

           //Saber cuantos elementos tiene el array o un String
           ages.length;
           





        }
    }
}