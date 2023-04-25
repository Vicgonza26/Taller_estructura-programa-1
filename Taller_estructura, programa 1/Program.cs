using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_estructura__programa_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado mi_empleado = new Empleado();

            mi_empleado.Cargar_Info();

            mi_empleado.Mostrar_Info();

            mi_empleado.Calcular_Impuestos();

            Console.ReadKey();
        }
    }
}
