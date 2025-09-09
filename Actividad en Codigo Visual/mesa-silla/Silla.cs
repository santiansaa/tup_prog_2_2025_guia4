using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesa_silla
{
    internal class Banco:Producto
    {
        public Banco(double precio, double largo) : base(precio, largo) { }

        public override double Peso()
        {
            return (base.largo * 0.25) * 0.42;
        }
        public override double Precio()
        {
            return Peso() * preciobase * 1.15;
        }
    }
}
