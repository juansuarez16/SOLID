using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Documento:IImprimible ,IGuardable,IEnviable
    {



        private void modificaciondeArchivo() { 
            //Logica de modificar un archivo
        }
        public void Imprimir() {
            Console.WriteLine("Imprimir");
        }

        public void Guardar() {
            Console.WriteLine("Guardado");
        }

        public void Enviar() {
            Console.WriteLine("Enviar");
        }
    }
}
