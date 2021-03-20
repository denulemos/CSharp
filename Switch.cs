using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {
            int num = 3;
            switch (num) {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                case 3:
                    Console.WriteLine("Tres")
                default:
                    Console.WriteLine("Ninguno"); // Se ejecuta cuando no se cumple ningun case
                    break;
            }

        }
    }
}