using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 1 
//Yosselin Roxana Flores García
namespace Clase_Teorica
{
    class Ejercicio1
    {

        static void Main(string[] args)
        {

            loops();
            Console.ReadLine();
        }
  
        public static void loops()
        {
            {
                //Se asignaron 10 posiciones para los datos
                int[] arraynumbers = new int[10];

                int x = 0;
                //Se pretende que el usuario introduzca los datos
                while (x < arraynumbers.Length)
                {
                    Console.WriteLine(" Ingrese el dato para la posición {0} ", x);
                    arraynumbers[x] = Convert.ToInt32(Console.ReadLine());
                    x++;
                }
                Console.WriteLine();


                //Se mostraran los datos que el usuario ha ingresado

                int j = 0;
                Console.WriteLine(" Datos ingresados, utilizando el ciclo While:");
                while (j < arraynumbers.Length)
                {
                    Console.WriteLine(arraynumbers[j]);
                    j++;
                }
            }

        }
    }
}