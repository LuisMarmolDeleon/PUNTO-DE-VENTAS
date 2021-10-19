using System;
using PUNTO_DE_VENTAS.procesador_de_productos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTAS.perfiles
{
    class Cliente
    {

        public static void Perfil_Cliente()
        {
            if (Listas.ListaCanasta.Count == 0 && Listas.ListaRopa.Count == 0 && Listas.ListaTech.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No tenemos stock en todas las categorias, vuelva pronto!\n\n");
                MainClass.Bienvenida();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Seleccione su categoria a comprar:\n");
                Console.WriteLine("1-Canasta Basica\n2-Vestimenta\n3-Tecnologia");
                Console.Write("4-Retroceder\n5-Salir\n\nSu opcion: ");

                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        if (Listas.ListaCanasta.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No tenemos articulos de canasta basica en el momento, vuelva mas tarde\n\n");
                            MainClass.Bienvenida();
                        }
                        else
                        {
                            Console.Clear();
                            procesador_de_productos.VentaProductos.Venta_Canasta();
                        }
                        break;

                    case 2:
                        if (Listas.ListaRopa.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No tenemos articulos de vestimenta en el momento, vuelva mas tarde\n\n");
                            MainClass.Bienvenida();
                        }
                        else
                        {
                            Console.Clear();
                            Adapter.Total.Totalcompra = 0;
                            AdapterVestimenta adapterV = new();
                            adapterV.Cobrar();
                        }
                        break;

                    case 3:
                        if (Listas.ListaTech.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No tenemos articulos de Tecnologia en el momento, vuelva mas tarde\n\n");
                            MainClass.Bienvenida();
                        }
                        else
                        {
                            Console.Clear();
                            Adapter.Total.Totalcompra = 0;
                            AdapterTech adaptert = new();
                            adaptert.Cobrar();
                        }
                        break;

                    case 4:
                        Console.Clear();
                        MainClass.Bienvenida();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Su opcion es incorrecta.\n\n");
                        Perfil_Cliente();
                        break;
                }
            }
        }
    }
}
