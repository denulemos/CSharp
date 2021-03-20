using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {
            for (int x = 0; x < 10; x += 3) { // for (;;) representa un bucle infinito
                Console.WriteLine(x); // 0 3 6 9
            }

            for (int y = 0; y > 0; y -= 2) {
                Console.WriteLine(y); // 10 8 6 4 2
            }

            for (x = 0; x < 10; x++) {
                if (x == 5)
                    continue; //Skippea el numero 5

                Console.WriteLine(i); // 0 1 2 3 4 6 7 8 9

            }

        }
    }
}