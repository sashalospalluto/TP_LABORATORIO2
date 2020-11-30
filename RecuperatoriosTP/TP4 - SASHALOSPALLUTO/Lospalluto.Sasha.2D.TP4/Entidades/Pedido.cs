using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        Queue<Carrito> PedidosEnPreparacion;
        List<Carrito> PredidosFinalizados;

        public static bool operator + (Pedido pedido, Carrito carrito)
        {
            bool agregado = false;

            if(carrito != null)
            {
                pedido.PedidosEnPreparacion.Enqueue(carrito);
                agregado = true;
            }           

            return agregado;
        }

        public static bool operator - (Pedido pedido, Carrito carrito)
        {
            bool finalizado = false;

            if (carrito != null)
            {
                pedido.PredidosFinalizados.Add(carrito);
                pedido.PedidosEnPreparacion.Dequeue();
                finalizado = true;
            }

            return finalizado;
        }
    }
}
