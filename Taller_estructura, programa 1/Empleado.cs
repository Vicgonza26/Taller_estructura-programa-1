using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Taller_estructura__programa_1
{
    public class Empleado
    {
        public string[] empleado { get; set; }
        public int[] sueldo { get; set; }

        public void Cargar_Info()
        {
            Console.WriteLine("Ingrese por favor el número de empleados");
            int num_empleado = int.Parse(Console.ReadLine());

            empleado = new string[num_empleado];
            sueldo = new int[num_empleado];

            for (int i = 0; i < num_empleado; i++)
            {
                Console.WriteLine("Por favor ingrese el nombre del empleado " + (i + 1));
                string nombre = Console.ReadLine();
                empleado[i] = nombre;

                Console.WriteLine("Por favor ingrese el sueldo del empleado " + (i + 1));
                int sueldo_empleado = int.Parse(Console.ReadLine());
                sueldo[i] = sueldo_empleado;
            }
        }
        public void Mostrar_Info()
        {
            for (int i = 0; i < empleado.Length; i++)
            {
                Console.WriteLine($"Nombre: {empleado[i]}");
                Console.WriteLine($"Sueldo: {sueldo[i]}");
            }
        }
        public void Calcular_Impuestos()
        {
            for (int i = 0; i < sueldo.Length; i++)
            {
                if (sueldo[i] > 52000000)
                {
                    Console.WriteLine("El empleado " + empleado[i] + " debe pagar impuesto.");
                }
                else
                {
                    Console.WriteLine("El empleado " + empleado[i] + " no debe pagar impuesto.");
                }

            }
        }
    }

}



            