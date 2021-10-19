using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTAS
{
    class AdapterVestimenta : IProducto
    {
        public void Cobrar()
        {
            FacturacionVestimenta fv = new();
            fv.Cobrar();
        }
    }
}
