using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Categoria2 : Categoria
    {

        public Categoria2(int numero, string NombreCategoria) 
        {
            this.NombreCategoria = NombreCategoria;
            this.NumeroCategoria = numero;
        }
        public override void Promocion() 
        {
            Console.WriteLine("Promoción 2 x 1.");
        }
        
    }
}
