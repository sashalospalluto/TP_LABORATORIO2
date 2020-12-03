using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ControlSql
    {
        static SqlConnection conexionBD;

        static ControlSql()
        {
            conexionBD = new SqlConnection("Data Source=.; Initial Catalog = TP4; integrated security = true");
        }

        //public static List<Pedido> GetPedidos ()
        //{
        //    List<Carrito> carritos = new List<Carrito>();
        //    List<Pedido> pedidos = new List<Pedido>();

        //    Producto producto;
        //    List<Producto.GustoHelado> gustos;
        //    Helado helado;

        //    SqlCommand command = new SqlCommand();

        //    command.Connection = conexionBD;
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "SELECT * FROM PEDIDOS";

        //    if(conexionBD.State != ConnectionState.Open)
        //    {
        //        conexionBD.Open();
        //    }

        //    SqlDataReader datoDeLaTabla = command.ExecuteReader();

        //    while (datoDeLaTabla.Read())
        //    {
        //        gustos = new List<Producto.GustoHelado>();

        //        if(datoDeLaTabla["producto"].ToString() == "Helado")
        //        {
        //            gustos.Add((Producto.GustoHelado)Enum.Parse(typeof(Producto.GustoHelado), datoDeLaTabla["gusto1"].ToString()));
        //            gustos.Add((Producto.GustoHelado)Enum.Parse(typeof(Producto.GustoHelado), datoDeLaTabla["gusto2"].ToString()));
        //            gustos.Add((Producto.GustoHelado)Enum.Parse(typeof(Producto.GustoHelado), datoDeLaTabla["gusto3"].ToString()));
        //            gustos.Add((Producto.GustoHelado)Enum.Parse(typeof(Producto.GustoHelado), datoDeLaTabla["gusto4"].ToString()));

        //            //helado = new Helado()

        //            //productoHelado = new Helado((Helado.Tamanio)Enum.Parse(typeof(Helado.Tamanio), cmbTamanio.SelectedItem.ToString()), gustos);
        //            //miCarrito += productoHelado;
        //            //miCarrito.CalcularTotal();
        //        }


        //        //producto = new Producto(gustos);
                
        //    }
            
        public static void SetCarrito(Carrito carrito)
        {
            //SqlCommand command = new SqlCommand(string.Format("INSERT INTO ");
            //command.Connection = conexionBD;
            //command.CommandType = CommandType.Text;
            //command.CommandText = "SELECT * FROM PEDIDOS";
        }


    }
}
