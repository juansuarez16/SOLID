using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class DescuentoPorcentaje:Descuento
    {
        private readonly double porcentaje;

        public DescuentoPorcentaje(double porcetaje) { 
            this.porcentaje = porcetaje;
        }

        public override double Calcular(double monto)
        {
            return monto / (porcentaje / 100);

        }
    }
}
