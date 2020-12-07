using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public enum EstadoDelPedido
    {
        EnPreparacion,
        Entregado
    }
    public class Carrito
    {
        private List<Producto> productos;
        private string nombreCliente;
        private double total;
        private int numeroDePedido;

        #region "Constructores" 
        /// <summary>
        /// Constructor que incializa los datos del carrito
        /// </summary>
        public Carrito()
        {
            Random random = new Random();
            this.productos = new List<Producto>();
            this.nombreCliente = random.Next(11111, 99999).ToString();
            this.total = 0;
        }

        /// <summary>
        /// Constructor que pide el nombre del cliente
        /// </summary>
        /// <param name="nombreCliente">nombre del cliente</param>
        public Carrito(string nombreCliente) : this()
        {
            this.nombreCliente = nombreCliente;

            
        }
        #endregion


        #region Operadores
        /// <summary>
        /// Operador que agrega un producto de tipo Helado al carrito de compras
        /// </summary>
        /// <param name="carrito">carrito</param>
        /// <param name="helado">Helado</param>
        /// <returns></returns>
        public static Carrito operator +(Carrito carrito, Helado helado)
        {
            if (helado != null)
            {
                carrito.productos.Add(helado);
            }

            return carrito;
        }

        /// <summary>
        /// operador que agrega un producto de tipo torta al carrito de compras
        /// </summary>
        /// <param name="carrito">carrito</param>
        /// <param name="torta">torta</param>
        /// <returns></returns>
        public static Carrito operator +(Carrito carrito, Torta torta)
        {
            if (torta != null)
            {
                carrito.productos.Add(torta);
            }
            return carrito;
        }
        #endregion


        #region Propiedades
        public string NombreCliente
        {
            get
            {
                return this.nombreCliente;
            }
            set
            {
                this.nombreCliente = value;
            }
        }

        public double Total
        {
            get
            {
                return this.CalcularTotal();
            }

        }

        public int NumeroDePedido
        {
            get
            {
                return this.numeroDePedido;
            }
            set
            {
                this.numeroDePedido = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que guarda un carrito en un archivo con extension .txt
        /// </summary>
        /// <param name="carrito">carrito a guardar</param>
        /// <returns>true si se guardó correctamente, caso contrario devuelve false</returns>
        public static bool Guardar(Carrito carrito)
        {
            Texto texto = null;

            try
            {
                texto = new Texto();

                texto.Guardar("Carritos", carrito.ToString());
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }

        /// <summary>
        /// Metodo que lee un carrito en un archivo con extension .txt
        /// </summary>
        /// <returns>cadena de string con los datos del carrito leido</returns>
        public static string Leer()
        {
            Texto texto = null;
            string carrito = null;

            try
            {
                texto = new Texto();
                texto.Leer("Jornada", out carrito);
            }
            catch (Exception)
            {

                throw;
            }

            return carrito;
        }

        /// <summary>
        /// Metodo override de ToString
        /// </summary>
        /// <returns>cadena de caracteres con los datos del carrito</returns>
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine($"----------PEDIDO {this.numeroDePedido}-------------");
            stb.AppendLine($"NOMBRE CLIENTE: {this.nombreCliente}");
            stb.AppendLine($"PEDIDO");
            foreach (Producto producto in this.productos)
            {
                stb.AppendLine(producto.ToString());
            }

            return stb.ToString();
        }

        /// <summary>
        /// Calcula el total del carrito
        /// </summary>
        /// <returns>cero si no hay productos en el carrito, caso contrario devuelve el total que suman los productos dentro del carrito</returns>
        public double CalcularTotal()
        {
            double total = 0;

            foreach (Producto producto in this.productos)
            {
                total += producto.Precio;
            }

            return total;
        } 
        #endregion

    }
}
