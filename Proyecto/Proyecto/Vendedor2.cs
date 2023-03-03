using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Vendedor2 : Vendedor,IVendedor2
    {
       

        public Vendedor2(string nombre)
        {
            this.Nombre = nombre;
        }

        public Vendedor2()
        {
        }

        public void MetodoVendedor2()
        {
            Console.WriteLine("Vendedor 2: " + Nombre);
        }

        public void VentasCredito()
        {
            throw new NotImplementedException();
        }
    }
}
