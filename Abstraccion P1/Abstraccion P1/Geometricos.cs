using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_P1
{
    public abstract class Geometricos
    {
        public abstract void Saludo();
        public abstract string Nombre { get; set; }

        public abstract void CalcularArea(double lado1, double lado2);
        public abstract void CalcularPerimetro(double lado1, double lado2);

    }
}
