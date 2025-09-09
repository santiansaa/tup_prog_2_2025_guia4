using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesa_silla
{
    abstract class Producto:IComparable
    {
        protected double preciobase;
        protected double largo;
        private int codigo;
        public int Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Producto(double precio, double largo) 
        {
            this.preciobase = precio;
            this.largo = largo;
        }

        public abstract double Peso();
        public abstract double Precio();

        public  int CompareTo(object otro) 
        {
            Producto p = otro as Producto;
            if (p != null) 
            {
                return this.codigo.CompareTo(p.codigo);
            }
            return -1;

        }
    }
}
