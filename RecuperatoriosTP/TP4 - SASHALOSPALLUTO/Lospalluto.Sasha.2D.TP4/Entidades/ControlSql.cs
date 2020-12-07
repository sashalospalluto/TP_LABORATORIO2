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

        /// <summary>
        /// Coneccion con la base de datos "TP4"
        /// </summary>
        static ControlSql()
        {
            conexionBD = new SqlConnection("Data Source=.; Initial Catalog = TP4; integrated security = true");
        }
        
        /// <summary>
        /// Guardo el carrito en mi base de datos
        /// </summary>
        /// <param name="carrito">carrito a guardar</param>
        public static void SetCarrito(Carrito carrito)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexionBD;

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO heladeria (numeroPedido,cliente,total) VALUES ('{0}','{1}','{2}')", carrito.NumeroDePedido, carrito.NombreCliente, carrito.Total);
            command.CommandText = sb.ToString();
            conexionBD.Open();          
           
            command.ExecuteNonQuery();
            conexionBD.Close();            
        }
    }
}
