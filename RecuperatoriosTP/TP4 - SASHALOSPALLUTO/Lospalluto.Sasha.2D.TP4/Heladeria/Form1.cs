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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbListaDeGustos.Items.AddRange(typeof(Producto.GustoHelado).GetEnumNames());
            cmbTipoDeProducto.Items.AddRange(typeof(Producto.Tipo).GetEnumNames());
        }

        private void cmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(cmbTipoDeProducto.Text == Producto.Tipo.Helado.ToString())
            {
                cmbTamanio.Items.Clear();
                cmbTamanio.Items.AddRange(typeof(Helado.TipoDeProducto).GetEnumNames());
            }
            else
            {
                cmbTamanio.Items.Clear();
                cmbTamanio.Items.AddRange(typeof(Torta.Tamanio).GetEnumNames());
            }
        }
    }
}
