using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {

            // Crear un diccionario
            Dictionary < string, int > dicts = new Dictionary < string, int > ();

            // Podemos crear e inicializar el diccionario al mismo tiempo
            var dict = new Dictionary < int,
                string > () {
                    {
                        23,
                        "Michael"
                    }, {
                        91,
                        "Dennis"
                    }
                };

            // Agregamos elementos al diccionario
            dict.Add("Ebenezer", 11);
            dict.Add("Pippin", 45);
            dict.Add("Estella", 37);

            // Accedemos mediante su key
            Console.WriteLine(dict["Ebenezer"]); //Devuelve 11
            Console.WriteLine(dict["Estella"]); //Devuelve 37

            // Contar cuantos elementos pares tengo
            dict.Count();

            // Ver todas las keys del diccionario
            var s = String.Join(", ", dict.Keys);

            // Lo mismo con los valores
            s = String.Join(", ", dict.Values);

            // Borrar todo el diccionario
            dicts.Clear();

            // Para saber sí hay alguna key especifica en el diccionario
            dict.ContainsKey(23);

            // Eliominar un elemento por su key
            dict.Remove(91);

        }
    }
}