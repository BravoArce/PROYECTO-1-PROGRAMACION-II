using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Articulo
    {
        protected string codigo;
        protected string nombre;
        protected double precio;


        private static readonly int MAX_ARTICULOS = 5;
        private static Articulo[] articulos = new Articulo[MAX_ARTICULOS];
        private static int numArticulos = 0;


        public Articulo()
        {

        }


        public Articulo(string codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }


        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }



        public void AgregarArticulo(Articulo articulo)
        {

            if (numArticulos < MAX_ARTICULOS)
            {
                articulos[numArticulos] = articulo;
                numArticulos++;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más artículos");
            }
        }


        public Articulo ConsultarArticulo(string codigo)
        {

            for (int i = 0; i < numArticulos; i++)
            {
                if (articulos[i].codigo == codigo)
                {
                    return articulos[i];
                }
            }

            return null;

        }


        public void BorrarArticulo(string codigo)
        {
            for (int i = 0; i < numArticulos; i++)
            {
                if (articulos[i].codigo == codigo)
                {

                    for (int j = i; j < numArticulos - 1; j++)
                    {
                        articulos[j] = articulos[j + 1];
                    }

                    articulos[numArticulos - 1] = null;
                    numArticulos--;

                    Console.WriteLine("Artículo borrado exitosamente");
                    return;
                }
            }

            Console.WriteLine("El artículo no existe");
        }
        public void listadoArticulos()
        {
            if (articulos[0] != null)
            {
                for (int i = 0; i < numArticulos; i++)
                {
                    Console.WriteLine("Código: " + articulos[i].codigo + ", Nombre: " + articulos[i].nombre + ", Precio: " + articulos[i].precio);
                }
            }
            else Console.WriteLine("No se han ingresado articulos.");



        }
    }
}
