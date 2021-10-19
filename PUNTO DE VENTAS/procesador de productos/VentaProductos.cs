using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTAS.procesador_de_productos
{
    class VentaProductos
    {
        private static int opcion = 0, swtch,cantidad,total,swtch2;

        public static void Venta_Canasta()
        {
            Listas.ImprimeCanasta();
            Console.WriteLine("Ingrese El producto a comprar: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Acaba de elegir: "+Listas.ListaCanasta[opcion]+":\n");
            Console.Write("1-Comprar\n2-No comprar\nSu opcion: ");
            swtch = Convert.ToInt32(Console.ReadLine());
            switch (swtch)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Elja la cantidad");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    total = Listas.PrecioCanasta[opcion] * cantidad;
                    Listas.ListaCompra.Add($"Producto: {Listas.ListaCanasta[opcion]} cantidad: {cantidad} precio:{total}");
                    Console.Clear();
                    Adapter.Total.Totalcompra += total;
                    Console.WriteLine("Se agrego: "+Listas.ListaCanasta[opcion]+" cantidad: "+cantidad+" precio total de unidades: "+total);
                    Console.WriteLine("\n\nDesea comprar mas articulos?\n1-Si\n2-Proceder a facturacion");
                    swtch2 = Convert.ToInt32(Console.ReadLine());
                    switch (swtch2)
                    {
                        case 1:
                            VentaProductos.Venta_Canasta();
                            break;

                        case 2:
                            Console.Clear();
                            foreach (string pr in Listas.ListaCompra)
                            {
                                Console.WriteLine(pr);
                            }
                            Console.WriteLine("Total: "+Adapter.Total.Totalcompra);
                            break;

                    }
                    break;
            }
        }
    }
}
