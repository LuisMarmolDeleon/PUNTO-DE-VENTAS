using System;
using PUNTO_DE_VENTAS.perfiles;
namespace PUNTO_DE_VENTAS
{
    class MainClass
    {


        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            else
            {
                Bienvenida();
            }
        }

        public static void Bienvenida()
        {
            Console.WriteLine("Bienvenido, ingrese su perfil:\n");
            Console.WriteLine("1-Cliente");
            Console.Write("2-Vendedor\n3-Salir\n\nSu opcion: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Cliente.Perfil_Cliente();
                    break;

                case 2:
                    Console.Clear();
                    Vendedor.Perfil_Vendedor();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Su opcion es incorrecta.\n\n");
                    Bienvenida();
                    break;
            }
        }
    }
}
