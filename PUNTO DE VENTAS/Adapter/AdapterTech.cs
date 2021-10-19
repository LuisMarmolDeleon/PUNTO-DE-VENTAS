using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTAS
{
    class AdapterTech : IProducto
    {
        
        public void Cobrar()
        {
            FacturacionTecnologico ft = new();
            ft.Cobrar();
        }
    }
}
