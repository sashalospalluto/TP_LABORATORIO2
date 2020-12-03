using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Heladeria
{
    public partial class Form1 : Form
    {
        Pedido pedido;
        Carrito miCarrito;
        Helado productoHelado;
        Torta productoTorta;
        public static int idCarrito=0;
        Thread hilo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbListaDeGustos.Items.AddRange(typeof(Producto.GustoHelado).GetEnumNames());
            cmbTipoDeProducto.Items.AddRange(typeof(Producto.Tipo).GetEnumNames());
            cmbTamanio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvCarrito.DataSource = null;
            pedido = new Pedido();
            pedido.PreparandoPedido += CargarPedido;
            pedido.PreparandoPedido += EntregarPedido;
            //productos = ControlSql.GetPedidos();          
        }

        private void cmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(cmbTipoDeProducto.Text == Producto.Tipo.Helado.ToString())
            {
                cmbTamanio.Items.Clear();
                cmbTamanio.Items.AddRange(typeof(Helado.Tamanio).GetEnumNames());
            }
            else
            {
                cmbTamanio.Items.Clear();
                cmbTamanio.Items.AddRange(typeof(Torta.Tamanio).GetEnumNames());
            }
        }

        private void cmbTipoDeProducto_TextChanged(object sender, EventArgs e)
        {            
            cmbTamanio.SelectedIndex = -1;
        }          

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            List<Producto.GustoHelado> gustos;

            if(dgvCarrito.Rows.Count==1)
            {
                idCarrito++;
                miCarrito.NumeroDePedido = idCarrito;
            }

            if (string.Equals(cmbTipoDeProducto.Text, Producto.Tipo.Helado.ToString()))
            {                
                gustos = CargarGustos();
                
                productoHelado = new Helado((Helado.Tamanio)Enum.Parse(typeof(Helado.Tamanio), cmbTamanio.SelectedItem.ToString()),gustos);
                miCarrito += productoHelado;
                miCarrito.CalcularTotal();
                CargaDataGridCarrito(productoHelado.TamanioDelHelado.ToString(),Producto.Tipo.Helado.ToString(), gustos, productoHelado.Precio);
            }

            if (string.Equals(cmbTipoDeProducto.Text, Producto.Tipo.Torta.ToString()))
            {           
                gustos = CargarGustos();

                productoTorta = new Torta((Torta.Tamanio)Enum.Parse(typeof(Torta.Tamanio), cmbTamanio.SelectedItem.ToString()), gustos);
                miCarrito += productoTorta;
                miCarrito.CalcularTotal();
                CargaDataGridCarrito(productoTorta.TamanioElegido.ToString(), Producto.Tipo.Torta.ToString(), gustos, productoTorta.Precio);
            }

            lblMontoTotal.Text = miCarrito.CalcularTotal().ToString();            
            
        }

        public List<Producto.GustoHelado> CargarGustos ()
        {
            List<Producto.GustoHelado> gustos = new List<Producto.GustoHelado>();
            foreach (int item in clbListaDeGustos.CheckedIndices)
            {
                if (clbListaDeGustos.GetItemChecked(item) == true)
                {
                    gustos.Add((Producto.GustoHelado)Enum.Parse(typeof(Producto.GustoHelado), item.ToString()));
                }
            }
            return gustos;
        }

        private void txbNombreCliente_Leave(object sender, EventArgs e)
        {
            miCarrito = new Carrito(txbNombreCliente.Text);
        }

        public void CargaDataGridCarrito(string tamanio, string tipo, List<Producto.GustoHelado> sabores, double precio)
        {
            int i = 4;
            
            int posiciones = dgvCarrito.Rows.Add();
            dgvCarrito[0, posiciones].Value = miCarrito.NumeroDePedido.ToString();
            dgvCarrito[1, posiciones].Value = tamanio;
            dgvCarrito[2, posiciones].Value = tipo;
            dgvCarrito[3, posiciones].Value = precio;

            foreach (Producto.GustoHelado gusto in sabores)
            {                
                dgvCarrito[i, posiciones].Value = gusto.ToString();
                i++;
            }
        }

        private void btnEfectuarPedido_Click(object sender, EventArgs e)
        {
            Carrito.Guardar(miCarrito);
            //pedido += miCarrito;

            this.hilo = new Thread(new ParameterizedThreadStart(pedido.CarritoAceptado));
            //this.hilo = new Thread(pedido.CarritoAceptado);
            this.hilo.Start(miCarrito);

            //int posiciones = dgvEnPreparacion.Rows.Add();
            //dgvEnPreparacion[0, posiciones].Value = miCarrito.NumeroDePedido.ToString();
            //dgvEnPreparacion[1, posiciones].Value = miCarrito.NombreCliente;
            //dgvEnPreparacion[2, posiciones].Value = miCarrito.Total;

            miCarrito = new Carrito();
            dgvCarrito.Rows.Clear();
            lblMontoTotal.Text = "0";
        }

        public void EntregarPedido(Carrito carrito)
        {
            
            if(dgvCarrito.InvokeRequired)
            {
                Preparacion delegado = new Preparacion(EntregarPedido);
                this.Invoke(delegado, new object[] { carrito });
            }
            else
            {
                Thread.Sleep(new Random().Next(5000, 5000));
                Pedido.EntregoPedido(carrito);
                //dgvEnPreparacion.DataSource = null;
                //int posiciones = dgvEnPreparacion.Rows.Add();
                //foreach (Carrito carritoRealizado in pedido.PedidosEnPreparacion)
                //{                    
                //    dgvEnPreparacion[0, posiciones].Value = carritoRealizado.NumeroDePedido.ToString();
                //    dgvEnPreparacion[1, posiciones].Value = carritoRealizado.NombreCliente;
                //    dgvEnPreparacion[2, posiciones].Value = carritoRealizado.Total;
                //}
                int posiciones = dgvFinalizados.Rows.Add();
                dgvFinalizados[0, posiciones].Value = carrito.NumeroDePedido.ToString();
                dgvFinalizados[1, posiciones].Value = carrito.NombreCliente;
                dgvFinalizados[2, posiciones].Value = carrito.Total;
                
            }
        }

        public void CargarPedido(Carrito carrito)
        {
            if (dgvCarrito.InvokeRequired)
            {
                Preparacion delegado = new Preparacion(CargarPedido);
                this.Invoke(delegado, new object[] { carrito });
            }
            else
            {
                Pedido.CargoPedido(carrito);
                int posiciones = dgvEnPreparacion.Rows.Add();
                dgvEnPreparacion[0, posiciones].Value = carrito.NumeroDePedido.ToString();
                dgvEnPreparacion[1, posiciones].Value = carrito.NombreCliente;
                dgvEnPreparacion[2, posiciones].Value = carrito.Total;
                //Thread.Sleep(new Random().Next(2000, 2000));
            }
        }

        private void dgvEnPreparacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
