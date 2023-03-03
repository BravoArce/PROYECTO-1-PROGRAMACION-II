using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public static class Menu
    {

        public static void MostrarMenu()
        {
            Articulo manejadorArticulo = new Articulo();
            Vendedores vendedores = new Vendedores();
            List<Categoria> listadoCategorias = new List<Categoria>();
            listadoCategorias.Add(new Categoria1(1, "Descuento de 15%."));
            listadoCategorias.Add(new Categoria2(2, "Promoción 2 x 1."));
            listadoCategorias.Add(new Categoria3(3, "Todo a mitad de precio."));

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("a. Artículos");
                Console.WriteLine("b. Facturación");
                Console.WriteLine("c. Reporte");
                Console.WriteLine("d. Salir");

                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case 'a':
                        OpcionArticulos(manejadorArticulo);
                        break;
                    case 'b':
                        OpcionFacturacion(manejadorArticulo, vendedores, listadoCategorias);
                        break;
                    case 'c':
                        OpcionReporte(vendedores, listadoCategorias, manejadorArticulo);
                        break;
                    case 'd':
                        return;
                    default:
                        Console.WriteLine("Opción inválida");
                        Console.ReadKey();
                        break;
                }
            }


        }
        private static object OpcionArticulos(Articulo manejadorArticulo)
        {


            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("a. Agregar");
                Console.WriteLine("b. Borrar");
                Console.WriteLine("c. Consultar");
                Console.WriteLine("d.Salir al menu Principal");


                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case 'a':
                        Articulo articulo = new Articulo();


                        Console.WriteLine("Digite el codigo del articulo");
                        articulo.Codigo = Console.ReadLine();

                        Console.WriteLine("Digite el nombre del articulo");
                        articulo.Nombre = Console.ReadLine();

                        Console.WriteLine("Digite el precio del articulo ");
                        articulo.Precio = double.Parse(Console.ReadLine());

                        manejadorArticulo.AgregarArticulo(articulo);

                        break;
                    case 'b':
                        Console.WriteLine("Digite el articulo a buscar por medio del codigo:");
                        String codigo = Console.ReadLine();

                        manejadorArticulo.BorrarArticulo(codigo);


                        break;
                    case 'c':

                        Console.WriteLine("Digite el articulo a buscar por medio del codigo:");
                        codigo = Console.ReadLine();

                        Articulo articuloConsultado = manejadorArticulo.ConsultarArticulo(codigo);
                        if (articuloConsultado != null)
                        {
                            Console.WriteLine("El codigo del articulo es " + articuloConsultado.Codigo + " el nombre es " + articuloConsultado.Nombre + "  El precio es " + articuloConsultado.Precio);
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }

                        break;

                    case 'd':

                        MostrarMenu();
                        break;
                }
            }
        }

        private static void OpcionFacturacion(Articulo manejadorArticulo, Vendedores vendedores, List<Categoria> listadoCategorias)
        {

            Console.WriteLine("Digite el articulo a buscar por medio del codigo:");
            String codigo = Console.ReadLine();

            Articulo articuloConsultado = manejadorArticulo.ConsultarArticulo(codigo);
            if (articuloConsultado != null)
            {
                Console.WriteLine("El codigo del articulo es " + articuloConsultado.Codigo + " el nombre es " + articuloConsultado.Nombre + "  El precio es " + articuloConsultado.Precio);

                Console.WriteLine("Ingrese una categoria");
                int categoriasDigitada = int.Parse(Console.ReadLine());
                switch (categoriasDigitada)
                {

                    case 1:
                        consultarCategoria(listadoCategorias[0]);
                        break;
                    case 2:
                        consultarCategoria(listadoCategorias[1]);
                        break;
                    case 3:
                        consultarCategoria(listadoCategorias[2]);
                        break;
                    default: Console.WriteLine("La categoria no existe."); break;
                }


                Categoria categoriaBuscada = listadoCategorias.FirstOrDefault(x => x.NumeroCategoria == categoriasDigitada);
                if (categoriaBuscada != null)
                {
                    Console.WriteLine("Digite el codigo del vendedor");
                    int codigoVendedor = int.Parse(Console.ReadLine());

                    string vendedorConsultado = vendedores.NombreVendedor(codigoVendedor);

                    Console.WriteLine(vendedorConsultado);
                }
                else
                {
                    Console.WriteLine("No existe la categoria Digitada");
                }

            }
            else
            {
                Console.WriteLine("No existe Articulo");
            }

        }
        private static void consultarCategoria(Categoria miCategoria)
        {
            if (miCategoria.categoriaExiste())
            {
                Console.WriteLine("La categoria existe");
                miCategoria.Promocion();
            }
        }

        private static void OpcionReporte(Vendedores vendedores, List<Categoria> listadoCategorias, Articulo manejadorArticulo)
        {

            Console.Clear();
            Console.WriteLine("Opción Reporte seleccionada");
            Console.WriteLine("Los vendedores actualmente trabajando son: ");
            vendedores.ListadoVendedores();
            if (listadoCategorias.Count > 0)
            {
                Console.WriteLine("Las categorias disponibles son: ");
                foreach (Categoria miCategoria in listadoCategorias)
                {
                    Console.WriteLine(miCategoria.NombreCategoria);
                }
            }
            else { Console.WriteLine("No hay categorias disponibles."); }
            Console.WriteLine("Los articulos ingresados son: ");
            manejadorArticulo.listadoArticulos();
            Console.ReadKey();
        }

    }
}
