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
using Excepciones;

namespace Heladeria
{
    public partial class Form1 : Form
    {
        Pedido pedido;
        Carrito miCarrito;
        Helado productoHelado;
        Torta productoTorta;
        public static int idCarrito = 0;

        public Form1()
        {
            InitializeComponent();
            pedido = new Pedido();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbListaDeGustos.Items.AddRange(typeof(Producto.GustoHelado).GetEnumNames());
            cmbTipoDeProducto.Items.AddRange(typeof(Producto.Tipo).GetEnumNames());
            cmbTamanio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvCarrito.DataSource = null;
            dgvEnPreparacion.DataSource = null;
            LimpiarCarrito();
        }

        private void cmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDeProducto.Text == Producto.Tipo.Helado.ToString())
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

        private void btnAgregarPedido_Click(object sender, EventArgs e)  //ACAAAAAAAAAAAAAAAA
        {
            List<Producto.GustoHelado> gustos;

            if (dgvCarrito.Rows.Count == 1)
            {
                idCarrito++;
                miCarrito.NumeroDePedido = idCarrito;
            }

            if (string.Equals(cmbTipoDeProducto.Text, Producto.Tipo.Helado.ToString()))
            {
                gustos = CargarGustos();

                productoHelado = new Helado((Helado.Tamanio)Enum.Parse(typeof(Helado.Tamanio), cmbTamanio.SelectedItem.ToString()), gustos);
                miCarrito += productoHelado;
                miCarrito.CalcularTotal();
                CargaDataGridCarrito(productoHelado.TamanioDelHelado.ToString(), Producto.Tipo.Helado.ToString(), gustos, productoHelado.Precio);
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
            btnEfectuarPedido.Enabled = true;
            txbNombreCliente.Enabled = false;

            cmbTamanio.SelectedIndex = -1;
            cmbTipoDeProducto.SelectedIndex = -1;
            for (int i = 0; i < clbListaDeGustos.Items.Count; i++)
            {
                clbListaDeGustos.SetItemChecked(i, false);
            }
        }

        /// <summary>
        /// Agrega los gustos marcados en el checkedListBox en una lista de gustos
        /// </summary>
        /// <returns>lista de gustos</returns>
        public List<Producto.GustoHelado> CargarGustos()
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

        /// <summary>
        /// Carga del dgvCarrito con el producto generado 
        /// </summary>
        /// <param name="tamanio">tamaño</param>
        /// <param name="tipo">tipo</param>
        /// <param name="sabores">gustos de helado</param>
        /// <param name="precio">precio</param>
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

        /// <summary>
        /// TEMA 19, 22, 23 Y 24 
        /// </summary>
        private void btnEfectuarPedido_Click(object sender, EventArgs e)
        {
            Carrito.Guardar(miCarrito);
            pedido += miCarrito;

            
            pedido.PreparandoPedido += EntregarPedido;

            int posiciones = dgvEnPreparacion.Rows.Add();
            dgvEnPreparacion[0, posiciones].Value = miCarrito.NumeroDePedido.ToString();
            dgvEnPreparacion[1, posiciones].Value = miCarrito.NombreCliente;
            dgvEnPreparacion[2, posiciones].Value = miCarrito.Total;
            
            ControlSql.SetCarrito(miCarrito);
            miCarrito = new Carrito();
            LimpiarCarrito();
        }

        /// <summary>
        /// Elimina el pedido del gvEnPreparacion y lo pasa a dgvFinalizados
        /// </summary>
        /// <param name="carrito">pedido a entregar</param>
        public void EntregarPedido(Carrito carrito)
        {
            if (dgvCarrito.InvokeRequired)
            {
                Preparacion delegado = new Preparacion(EntregarPedido);
                this.Invoke(delegado, new object[] { carrito });
            }
            else
            {
                if (dgvEnPreparacion.Rows.Count > 1)
                {
                    dgvEnPreparacion.Rows.RemoveAt(0);
                }

                ActualizarPedidosEntregados();
            }
        }
        
        /// <summary>
        /// Agrego el carrito a dgvEnPreparacion 
        /// </summary>
        /// <param name="carrito">carrito que pasa a ser un pedido en preparacion</param>
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

                this.EntregarPedido(carrito);
            }
        }

        /// <summary>
        /// Limpio todos los campos del pedido
        /// </summary>
        public void LimpiarCarrito()
        {
            dgvCarrito.Rows.Clear();
            txbNombreCliente.Clear();

            txbNombreCliente.Enabled = true;

            for (int i = 0; i < clbListaDeGustos.Items.Count; i++)
            {
                clbListaDeGustos.SetItemChecked(i, false);
            }
            
            lblMontoTotal.Text = "0";
            cmbTamanio.SelectedIndex = -1;
            cmbTipoDeProducto.SelectedIndex = -1;

            cmbTamanio.Enabled = false;
            clbListaDeGustos.Enabled = false;
            cmbTipoDeProducto.Enabled = false;
            btnAgregarPedido.Enabled = false;
            btnEfectuarPedido.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            LimpiarCarrito();
            idCarrito--;
        }

        /// <summary>
        /// Actualizo dgvFinalizados
        /// </summary>
        public void ActualizarPedidosEntregados()
        {
            dgvFinalizados.Rows.Clear();

            foreach (Carrito carrito in pedido.PedidosFinalizados)
            {
                int posiciones = dgvFinalizados.Rows.Add();
                dgvFinalizados[0, posiciones].Value = carrito.NumeroDePedido.ToString();
                dgvFinalizados[1, posiciones].Value = carrito.NombreCliente;
                dgvFinalizados[2, posiciones].Value = carrito.Total;
            }
        }

        private void cmbTipoDeProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTamanio.Enabled = true;
        }

        private void txbNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (txbNombreCliente.TextLength != 0)
            {
                cmbTipoDeProducto.Enabled = true;
            }
            else
            {
                cmbTipoDeProducto.Enabled = false;
            }
        }

        private void cmbTamanio_SelectedValueChanged(object sender, EventArgs e)
        {
            clbListaDeGustos.Enabled = true;
        }

        private void clbListaDeGustos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (clbListaDeGustos.CheckedIndices.Count <= ValidarMaximoDeGustos())
                {
                    btnAgregarPedido.Enabled = true;                    
                }
                else
                {
                    btnAgregarPedido.Enabled = false;
                    throw new GustosException($"demasiados gustos, solo se permiten {ValidarMaximoDeGustos()} gustos para este producto, deseleccione uno o intente con otro producto");
                }
            }
            catch (GustosException ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void clbListaDeGustos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (clbListaDeGustos.CheckedIndices.Count <= ValidarMaximoDeGustos())
                {
                    btnAgregarPedido.Enabled = true;
                }
                else
                {
                    btnAgregarPedido.Enabled = false;
                    throw new GustosException($"demasiados gustos, solo se permiten {ValidarMaximoDeGustos()} gustos para este producto, deseleccione uno o intente con otro producto");
                    
                }
            }
            catch (GustosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Valido cual es la cantidad maxima de gustos segun el tipo de producto y su tamaño
        /// </summary>
        /// <returns></returns>
        public int ValidarMaximoDeGustos()
        {
            int maximo=0;
            Helado heladoAux=new Helado();
            Torta tortaAux = new Torta();

            if ((string.Equals(cmbTipoDeProducto.Text, Producto.Tipo.Helado.ToString())))
            {                
                heladoAux.TamanioDelHelado = (Helado.Tamanio)Enum.Parse(typeof(Helado.Tamanio), cmbTamanio.SelectedItem.ToString());
                maximo = heladoAux.TamanioDelHelado.CantidadDeGustosPermitidos();
            }
            if (string.Equals(cmbTipoDeProducto.Text, Producto.Tipo.Torta.ToString()))
            {
                tortaAux.TamanioElegido = (Torta.Tamanio)Enum.Parse(typeof(Torta.Tamanio), cmbTamanio.SelectedItem.ToString());
                maximo = tortaAux.TamanioElegido.CantidadDeGustosPermitidos();
            }

            return maximo;
        }
               
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //no deja que se cierre el boton
            }

            Pedido.CerrarHilos();
            //Pedido.Guardar(pedido);
        }
    }
}