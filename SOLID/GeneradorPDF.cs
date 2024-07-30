using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class GeneradorPDF:IGenerador
    {

        public void Generar() {
            Console.WriteLine("Generando PDF");
        }
    }
}
