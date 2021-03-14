using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {

            // Recursividad
            static int Factorial(int number) {
                int result;
                if (number == 1) {
                    return 1;
                } else {
                    result = Factorial(number - 1) * number;
                    return result;
                }
            }
            int factorial = Factorial(5);
            Console.Write(factorial);


            // Cuando no sabes cuantos parametros de un tipo vas a recibir 

            static int Totalize(params int[] numbers) {
                int result = 0;
                foreach(int number in numbers) { //Operamos con foreach
                    result += number;
                }
                return result;
            }




        }
    }
}