using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Vendedores
    {
        Dictionary<int, Vendedor> listaVendedores = new Dictionary<int, Vendedor>();

        public void AgregarElemento()
        {

            Vendedor1 vendedor1 = new Vendedor1("Luis Perez ");
            Vendedor2 vendedor2 = new Vendedor2("Alexa Mendoza ");

            listaVendedores.Add(1, vendedor1);
            listaVendedores.Add(2, vendedor2);

        }

        public Vendedores()
        {
            AgregarElemento();
        }

        public void ListadoVendedores()
        {


            foreach (KeyValuePair<int, Vendedor> Vendedores in listaVendedores)

            {
                Console.WriteLine("Codigo: {0}  Nombre: {1}", Vendedores.Key, listaVendedores[Vendedores.Key].Nombre);
            }
        }


        public string NombreVendedor(int codigo)
        {
            if (listaVendedores.ContainsKey(codigo))
            {
                return "El vendedor consultado es: " + listaVendedores[codigo].Nombre;
            }
            else
            {
                return "El vendedor indicado no existe";
            }

        }

    }
}
