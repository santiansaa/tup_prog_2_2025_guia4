using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesa_silla
{
    internal class Mesa:Producto
    {
        private double ancho;
        private double grosor;

        public Mesa(double precio,double largo,double ancho,double grosor):base(precio,largo)
        {
            this.ancho = ancho;
            this.grosor = grosor;
        }

        public override double Peso()
        {
            return (base.largo * ancho * grosor) * 0.3;
        }
        public override double Precio()
        {
            return Peso() * base.preciobase * 1.25;
        }
    }
}
