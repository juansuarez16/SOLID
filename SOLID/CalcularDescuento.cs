using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class CalcularDescuento
    {
        public double CalcDescuento(Descuento descuento,double monto)
        {
            return Descuento.Calcular(monto);

        }
    }
}
