using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Reporte
    {
        private readonly IGenerador generador;

        public Reporte(IGenerador generador) { 
            this.generador = generador;
        }

        public void Generar() { 
            generador.Generar();
        }
    }
}
