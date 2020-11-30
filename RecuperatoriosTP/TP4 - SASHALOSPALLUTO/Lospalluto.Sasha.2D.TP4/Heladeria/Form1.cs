using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Heladeria
{
    public partial class Form1 : Form
    {
        Pedido pedido;
        Carrito miCarrito;
        Producto producto;
        List<Producto.GustoHelado> gustos;

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
            gustos = new List<Producto.GustoHelado>();
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
            //if(cmbTipoDeProducto.Text == Producto.Tipo.Helado.ToString())
            //{
            //    producto = new Helado();
                

            //    for (int i = 0; i < clbListaDeGustos.Items.Count; i++)
            //    {
            //        if(clbListaDeGustos.GetItemChecked(i)==true)
            //        {
            //            gustos.Add((Producto.GustoHelado)Enum.Parse(typeof(Producto.GustoHelado), clbListaDeGustos.GetItemChecked(i).ToString()));
            //        }
            //    }
                
            //}           

        }

        
    }
}
