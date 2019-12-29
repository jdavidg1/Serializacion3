using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de atributos

            string añoFabricacion;
            double valorEconomico;

            Console.WriteLine("Cual es el año de fabricación del vehículo");

            añoFabricacion = Console.ReadLine();
            Console.WriteLine("Cual es el costo del vehiculo");
            valorEconomico = Convert.ToDouble(Console.ReadLine());

            //instaciar la variable

            CAuto miAuto = new CAuto(añoFabricacion, valorEconomico);

            //Presentación en pantalla de los valores.

            miAuto.PresentarInformacion();


            Console.ReadKey();

        }
    }
}
