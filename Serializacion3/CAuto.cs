using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion3
{
    [Serializable]
    class CAuto
    {
        //Declaración de atributos
        private string modelo;
        private double precio;

        //Declaración del constructor

        public CAuto (string dModelo, double dPrecio)
        {
            modelo = dModelo;
            precio = dPrecio;
        }


        //Método para presentar la información

        public void PresentarInformacion()
        {
            Console.WriteLine("El modelo de tu carro es {0}", modelo);
            Console.WriteLine("El costo de tu carro es " + precio);
            Console.WriteLine("-----------");

        }



    }
}
