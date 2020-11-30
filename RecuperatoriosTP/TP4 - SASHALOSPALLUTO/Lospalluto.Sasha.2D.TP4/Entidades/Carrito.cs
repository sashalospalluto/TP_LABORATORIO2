using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        List<Producto> productos;
        string nombreCliente;
        double total;

        public Carrito ()
        {
            Random random = new Random();
            productos = new List<Producto>();
            nombreCliente = random.Next(11111,99999).ToString();
            total = 0;
        }

        public Carrito (string nombreCliente, Producto producto) :this()
        {
            this.nombreCliente = nombreCliente;
            productos.Add(producto);

        }

        public double CalcularTotal()
        {
            double total=0;

            foreach (Producto producto in this.productos)
            {
                total += producto.Precio();
            }

            return total;
        }

        
    }
}
