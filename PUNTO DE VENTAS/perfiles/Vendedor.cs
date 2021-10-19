using PUNTO_DE_VENTAS.procesador_de_productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTAS.perfiles
{
    class Vendedor
    {
       

        public static void Perfil_Vendedor()
        {
            Console.WriteLine("Que desea hacer?\n");
            Console.WriteLine("1-Agregar Producto");
            Console.Write("2-Retroceder\n\nSu opcion: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Agregar_Producto();
                    break;

                case 2:
                    Console.Clear();
                    MainClass.Bienvenida();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Su opcion es incorrecta.\n\n");
                    Perfil_Vendedor();
                    break;
            }
        }

        public static void Agregar_Producto()
        {
            Console.WriteLine("Elija la categoria del producto: ");
            Console.WriteLine("1-Canasta Basica\n2-Vestimenta\n3-Tecnologia");
            Console.Write("4-Retroceder\n5-Salir\n\nSu opcion: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    AgregarProductos.Canasta_Basica();
                    break;

                case 2:
                    Console.Clear();
                    AgregarProductos.Vestimenta();
                    break;

                case 3:
                    Console.Clear();
                    AgregarProductos.Tecnologia();
                    break;

                case 4:
                    Perfil_Vendedor();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Su opcion es incorrecta.\n\n");
                    Agregar_Producto();
                    break;
            }
        }
    }
}
