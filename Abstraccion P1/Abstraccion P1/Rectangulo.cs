using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_P1
{
   public class Rectangulo:Geometricos
    {
        public override string Nombre { get ; set ; }

        public override void Saludo()
        {
            Console.WriteLine("La figura es un Rectangulo");
        }
        public override void CalcularArea(double lado1 = 10, double lado2 = 6)
        {
            var Res = lado1 * lado2;
            Console.WriteLine("El area de un rectangulo es: " + Res);
        }
        public override void CalcularPerimetro(double lado1 = 10, double lado2 = 6)
        {
            var Res = 2 * (lado1 + lado2);
            Console.WriteLine("El perimetro de un rectangulo es: " + Res);
        }
    }
}
