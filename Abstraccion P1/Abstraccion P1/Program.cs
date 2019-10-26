using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_P1
{
   public class Program
    {
        static void Main(string[] args)
        {

            Triangulo tri = new Triangulo();
            tri.Saludo();
            tri.CalcularArea();
            tri.CalcularPerimetro();

            Cuadrado cua = new Cuadrado();
            cua.Saludo();
            cua.CalcularArea();
            cua.CalcularPerimetro();

            Rectangulo rec = new Rectangulo();
            rec.Saludo();
            rec.CalcularArea();
            rec.CalcularPerimetro();
            Console.ReadKey();
        }
    }
}
