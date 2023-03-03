using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Categoria
    {
        public int NumeroCategoria { get; set; }
        public string NombreCategoria { get; set; }




        public virtual void Promocion()
        {
            Console.WriteLine("Descuentos y Promociones: ");

        }


        public bool categoriaExiste()
        {
            return true;


        }


    }
}
