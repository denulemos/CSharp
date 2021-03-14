using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {

            /*  La lista es parecida al array en el hecho de que ambas son colecciones, 
            aunque las listas pueden cambiar su capacidad a medida que agregamos elementos. */

            // Crear una Lista, hay 2 maneras
            List < int > ages = new List < int > ();
            var names = new List < string > ();

            // Crear Lista a partir de un array
            int[] array = {
                1,
                2,
                3
            };
            var list = new List < int > (array);
            string s = String.Join(", ", list);
            Console.WriteLine(s);


            /* Sí tenemos una lista de elementos numericos, como integer o double, 
            para mostrarlos por pantalla debemos covertirlos a String 
            (y sí queremos, separarlo por comas) */

            List < double > times = new List < double > (); //Creamos la lista
            times.Add(4.20);
            times.Add(7.30); //Agregamos elementos a la lista
            times.Add(9.35);
            string s = String.Join(", ", times); //Pasamos los valores a un String con los mismos separados por comas
            Console.WriteLine(s);

            // Saber cantidad de elementos de una lista
            times.Count();

            // Insertar elemento en cierto lugar de la lista
            times.Insert(1, 6.20); // El primer numero es la posicion, y el segundo el elemento

            //Ordenar elementos
            times.Sort();

            // Eliminar elementos por el elemento exacto
            times.Remove(7.30);

            // Eliminar elemento mediante su posicion
            times.RemoveAt(2);

            // Saber si algun elemento X existe en mi lista, devuelve booleano
            times.Contains(1.00);

            //Para saber en que lugar esta cierto elemento, sí el elemento no existe en mi lista, devolvera un -1
            times.IndexOf(2.00)



        }
    }
}