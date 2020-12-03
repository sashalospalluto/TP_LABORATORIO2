using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public delegate void Preparacion(Carrito carrito);
    public class Pedido
    {
        static Queue<Carrito> pedidosEnPreparacion;
        static List<Carrito> pedidosFinalizados;
        public event Preparacion PreparandoPedido;

        public void CarritoAceptado(object carrito)
        {
            Carrito carritoAux = new Carrito();
            while(true)
            {
                //Thread.Sleep(new Random().Next(2000, 7000));
                if (this.PreparandoPedido != null && carritoAux!=carrito)
                {
                    carritoAux = (Carrito)carrito;
                    this.PreparandoPedido.Invoke((Carrito)carrito);
                    Thread.Sleep(new Random().Next(500, 500));
                }
            }
        }

        public static void CargoPedido(Carrito carrito)
        {
            pedidosEnPreparacion.Enqueue(carrito);
            //Thread.Sleep(new Random().Next(2000, 7000));
        }

        public static void EntregoPedido(Carrito carrito)
        {
            pedidosEnPreparacion.Dequeue();
            pedidosFinalizados.Add(carrito);
        }

        public Pedido()
        {
            //this.PreparandoPedido += CargoPedido;
            //this.PreparandoPedido += EntregoPedido;
        }

        public Queue<Carrito> PedidosEnPreparacion
        {
            get
            {
                return pedidosEnPreparacion;
            }
        }

        static Pedido()
        {
            pedidosEnPreparacion = new Queue<Carrito>();
            pedidosFinalizados = new List<Carrito>();
           
        }

        /// <summary>
        /// Metodo que lee los datos de un archivo con extension .xml
        /// </summary>
        /// <returns>cadena de string con los datos del pedido leido</returns>
        public static Pedido Leer()
        {
            Xml<Pedido> xml = new Xml<Pedido>();

            xml.Leer("Pedido", out Pedido pedido);

            return pedido;
        }

        /// <summary>
        /// Metodo que guarda el pedido en un archivo con extension .xml
        /// </summary>
        /// <param name="pedido">universidad a guardad</param>
        /// <returns>true si se guardó correctamente, caso contrario devuelve false</returns>
        public static bool Guardar(Pedido pedido)
        {
            Xml<Pedido> xml = new Xml<Pedido>();

            return xml.Guardar("Pedido", pedido); ;
        }


        public static Pedido operator + (Pedido pedido, Carrito carrito)
        {   
            if(carrito != null)
            {
                pedidosEnPreparacion.Enqueue(carrito);
                
            }           

            return pedido;
        }

        public static Pedido operator - (Pedido pedido, Carrito carrito)
        {         
            if (carrito != null)
            {
                pedidosFinalizados.Add(carrito);
                pedidosEnPreparacion.Dequeue();
                
            }

            return pedido;
        }


    }
}
