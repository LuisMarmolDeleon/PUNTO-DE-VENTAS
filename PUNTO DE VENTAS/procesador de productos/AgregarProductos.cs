using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTAS.procesador_de_productos
{
    class AgregarProductos
    {
        private static string nombre;
        private static int precio,op;

        public static void Canasta_Basica()
        {
            Console.Clear();
            Console.WriteLine("Inserte nombre de producto: ");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese precio para el producto: " + nombre+": ");
            precio = Convert.ToInt32(Console.ReadLine());

            Listas.ListaCanasta.Add($"Descripcion: {nombre}|Precio: {precio}");
            Listas.PrecioCanasta.Add(precio);


            Console.Clear();
            Console.WriteLine("Desea agregar otro producto de canasta basica?");
            Console.Write("1-si\n2-no\nSu opcion: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Canasta_Basica();
                    break;

                case 2:
                    Console.Clear();
                    perfiles.Vendedor.Perfil_Vendedor();
                    break;
            }
        }

        public static void Vestimenta()
        {

            Console.Clear();
            Console.WriteLine("Inserte nombre de producto: ");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese precio para el producto: " + nombre + ": ");
            precio = Convert.ToInt32(Console.ReadLine());
            Listas.ListaRopa.Add($"|Descripcion: {nombre}|Precio: {precio}");
            Listas.PrecioRopa.Add(precio);



            Console.Clear();
            Console.WriteLine("Desea agregar otro producto de Vestimenta?");
            Console.Write("1-si\n2-no\nSu opcion: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Vestimenta();
                    break;

                case 2:
                    Console.Clear();
                    perfiles.Vendedor.Perfil_Vendedor();
                    break;
            }
        }

        public static void Tecnologia()
        {
            Console.WriteLine("Inserte nombre de producto: ");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese precio para el producto: " + nombre + ": ");
            precio = Convert.ToInt32(Console.ReadLine());
            Listas.ListaTech.Add($"|Descripcion:{nombre}| Precio:{precio}|");
            Listas.PrecioTech.Add(precio);

            Console.Clear();
            Console.WriteLine("Desea agregar otro producto de Tecnologia?");
            Console.Write("1-si\n2-no\nSu opcion: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Tecnologia(); 
                    break;

                case 2:
                    Console.Clear();
                    perfiles.Vendedor.Perfil_Vendedor();
                    break;
            }
        }
    }
}
