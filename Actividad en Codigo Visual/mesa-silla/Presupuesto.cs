using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesa_silla
{
    internal class Presupuesto
    {
        List<Producto> listaProductos = new List<Producto>();
        Cliente solicitante;
        public double Precio 
        {
            get { return Precio; }
            set { Precio = value; }
        }
        public Presupuesto(string nombre, string direccion) 
        {
            solicitante = new Cliente(nombre, direccion);
        }

        public void AgregarProducto(Producto unproducto) 
        {
            listaProductos.Add(unproducto);
            Precio += unproducto.Precio();
        }

        private Producto BuscarProducto(int codigo) 
        {
            listaProductos.Sort();
            Banco b = new Banco(0, 0);
            b.Codigo = codigo;
            int idx = listaProductos.BinarySearch(b);
            if (idx > -1) 
            {
                return listaProductos[idx] as Producto;
            }
            return null;
        }

        public bool QuitarProducto(int codigo) 
        {
            Producto p = BuscarProducto(codigo);
            if (p != null) 
            {
                listaProductos.Remove(p);                
            }
            return false;
        }
    }
}
