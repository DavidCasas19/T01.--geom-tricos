using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_P1
{
    class Cuadrado : Geometricos
    {
        public override string Nombre { get ; set ; }

        public override void Saludo()
        {
            Console.WriteLine("La figura es un Cuadrado");
        }
        public override void CalcularArea(double lado1 = 10, double lado2 = 10)
        {
            double Res = lado1 * lado2;
            Console.WriteLine("El area del cuadrado es: " + Res);
        }
        public override void CalcularPerimetro(double lado1 = 10, double lado2 = 10)
        {
            var Res = lado1 + lado2 + lado1 + lado2;
            Console.WriteLine("El perimetro del cuadrado es: " + Res);
            Console.WriteLine("");
        }
    }
    }
