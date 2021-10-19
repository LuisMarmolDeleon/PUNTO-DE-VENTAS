using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTAS.procesador_de_productos
{
    class Listas
    {
        public static List<string> ListaCanasta = new();

        public static List<int> PrecioCanasta = new();

        public static List<string> ListaRopa = new();
        public static List<int> PrecioRopa = new();


        public static List<string> ListaTech = new();
        public static List<int> PrecioTech = new();


        public static List<string> ListaCompra = new();

        public static void ImprimeCanasta()
        {
            for(int i = 0; i<ListaCanasta.Count; i++)
            {
                Console.WriteLine("ID: "+i+" "+ListaCanasta[i]);
            }
            Console.WriteLine("\n");

        }

        public static void Imprimeropa()
        {
            for (int i = 0; i <ListaRopa.Count; i++)
            {
                Console.WriteLine("ID: " + i + " " + ListaRopa[i]);
            }
            Console.WriteLine("\n");

        }

        public static void Imprimetech()
        {
            for (int i = 0; i < ListaTech.Count; i++)
            {
                Console.WriteLine("ID: " + i + " " + ListaTech[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
