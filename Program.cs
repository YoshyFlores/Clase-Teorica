using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Teorica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamando al metodo loops
            loops();
            Console.ReadLine();
        }
        //Bucles
        //Voy a crear un metodo que no retornara, tipo void
        public static void loops()
        {
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //Ciclo while
            //mientras sea verdadera se va a ejecutar

            int i = 0;
            Console.WriteLine("Imprime elementos con While");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++; //i=i+1
                //cuantos elementos tiene el arreglo, length

            }
            //imprime la primera vez 
            //Se puede usar cuando quiero mostrar una salida en especifico.
            Console.WriteLine("Imprime elementos con DO- WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (10 < numbers.Length);

            Console.WriteLine("IMPRIME CON FOR");
                for (int j = 0; j < numbers.Length; j++) 
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);
            }

            Console.WriteLine("Imprime elementos con FOREACH");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        //Escribir un ciclo que permita capturar los valores
        //a almacenar en el arreglo de numbers con un tamaño de 10
    }
}
