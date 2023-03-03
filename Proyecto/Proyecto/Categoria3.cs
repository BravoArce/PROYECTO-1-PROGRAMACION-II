using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Categoria3 : Categoria
    {
        public Categoria3(int numero, string NombreCategoria)
        {
            this.NombreCategoria = NombreCategoria;
            this.NumeroCategoria = numero;
        }
        public override void Promocion()
        {
            Console.WriteLine("Todo a mitad de precio.");
        }

    }
}
