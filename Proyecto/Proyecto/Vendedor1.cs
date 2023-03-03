using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Vendedor1 : Vendedor , IVendedor1
    {
        


        public Vendedor1(string nombre)
        {
            this.Nombre = nombre;
        }

        public Vendedor1()
        {
        }

        public void MetodoVendedor1()
        {
            Console.WriteLine("Vendedor 1: " + Nombre);
        }

        public void VentasContado()
        {
            throw new NotImplementedException();
        }
    }
}

