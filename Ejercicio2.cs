using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Teorica
{
    //Yosselin Roxana Flores García
    //Ejercicio 2
    //Calcular el promedio de los numeros almacenados en el array.
    class Ejercicio2
    {
        static void Main(string[] args)
        { 
            loops();
            Console.ReadLine();
        }
        public static void loops()
        {
            {
                int[] arraynumeros = new int[10];

                int sumatoria = 0;
                double promedio;

                int x = 0;
                //Utilizamos while
                while (x < arraynumeros.Length)
                {
                    Console.WriteLine("Ingrese el dato en la posicion {0}", x);
                    arraynumeros[x] = Convert.ToInt32(Console.ReadLine());
                    x++;
                }
                Console.WriteLine();

                int a = 0;
                Console.WriteLine("Datos ingresados, utilizando el ciclo While");
                while (a < arraynumeros.Length)
                {
                    Console.WriteLine(arraynumeros[a]);
                    a++;
                }
                Console.WriteLine();

                //Se pretende mostrar el promedio utilizando los datos que se han adquerido anteriormente
                //Primero se realizará una suma de los datos que se tienen y posteriosmente se dividira entre el numero de datos que se sumaron.
                for (int num = 0; num < 10; num++)
                {
                    sumatoria = sumatoria + arraynumeros[num];
                }
                promedio = sumatoria / arraynumeros.Length;

                Console.WriteLine("El promedio de los datos ingresados es: {0}", promedio);

            }
        }
    }
}


