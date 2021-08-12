using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Teorica
{
    class Colecciones
    {

        static void Main(string[] args)
        {
            //diccionario
            //almacena pares de dato clase y valor
            //Definir un diccionario

            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            //agregar elementos al diccionario
            EmployeeList.Add("Jose Flore", "Programador");
            EmployeeList.Add("Miranda Campos", "Gerente");
            EmployeeList.Add("Carmen Valladares", "Arquitecta");


            /*Dictionary<string, int> Students = new Dictionary<string, int>();
            EmployeeList.Add("Jose Flore", 22);
            EmployeeList.Add("Miranda Campos", 20);
            EmployeeList.Add("Carmen Valladares", 24);*/

            //Leer el diccionario y mostrar los datos
            foreach (KeyValuePair<string, string> employee in EmployeeList) 

            {
                Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }
            var dic = EmployeeList.Keys.ToList();

            dic.Sort();
            Console.WriteLine("Diccionario ordenado");
            foreach (var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, EmployeeList[item]);
            }

           // Console.WriteLine("Elementos en el diccionario:{0}", EmployeeList.Count);
            Console.ReadKey();
        }
    }
}

