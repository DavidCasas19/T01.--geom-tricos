using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_P1
{
    public class Triangulo : Geometricos
    {
        public override string Nombre { get; set; }
       
    
        public override void Saludo()
        {
            Console.WriteLine("La figura es un Triangulo");
        }
        public override void CalcularArea(double lado1 = 5, double lado2 = 10)
        {
            var Res = lado1 * lado2 / 2;
            Console.WriteLine("El area del triangulo es: " + Res);

        }
        public override void CalcularPerimetro(double lado1 = 5, double lado2 = 10)
        {
            Console.WriteLine("Su perimetro no se puede calcular");
            Console.WriteLine("");
        }
    }
}
