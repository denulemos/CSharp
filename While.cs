using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {
           int num = 0;
           while(++num < 6)
           Console.WriteLine(num); // Se ejecuta 5 veces. Suma antes de chequear si la condicion es mayor de 6

        }
    }
}