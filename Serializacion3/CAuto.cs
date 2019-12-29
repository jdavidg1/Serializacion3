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




    }
}
