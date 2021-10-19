using System;
using PUNTO_DE_VENTAS.procesador_de_productos;
using PUNTO_DE_VENTAS.Adapter;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTAS
{
    class FacturacionVestimenta
    {
        private int opcion, swtch, cantidad = 0, total = 0, swtch2 = 0;
        public  void Cobrar()
        {
            
            Listas.Imprimeropa();
            Console.WriteLine("Ingrese El producto a comprar: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Acaba de elegir: " + Listas.ListaRopa[opcion] + ":\n");
            Console.Write("1-Comprar\n2-No comprar\nSu opcion: ");
            swtch = Convert.ToInt32(Console.ReadLine());
            switch (swtch)
            {
                case 1:
                    Console.WriteLine("Elja la cantidad");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    total = Convert.ToInt32(Listas.PrecioRopa[opcion]) * cantidad;
                    Listas.ListaCompra.Add($"Producto: {Listas.PrecioRopa[opcion]} cantidad: {cantidad} precio: {total}");
                    Console.Clear();
                    Console.WriteLine("Se agrego: " + Listas.ListaRopa[opcion] + " cantidad: " + cantidad + " precio total de unidades: " + total);

                    Adapter.Total.Totalcompra += total;
                    Console.WriteLine("\n\nDesea comprar mas articulos?\n1-Si\n2-Proceder a facturacion");
                    swtch2 = Convert.ToInt32(Console.ReadLine());
                    switch (swtch2)
                    {
                        case 1:
                            Cobrar();
                            break;

                        case 2:
                            foreach (string pr in Listas.ListaCompra)
                            {
                                Console.WriteLine(pr);
                            }
                            Console.WriteLine("ITBIS: " + Adapter.Total.Totalcompra * 0.18);
                            Console.WriteLine("Total: " + Adapter.Total.Totalcompra);
                            break;

                    }
                    break;
            }
        }
    }
}
