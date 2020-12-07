using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

//TEMA 16
namespace TestUnitarios
{
    /// <summary>
    /// Descripción resumida de TestPruebasEntidades
    /// </summary>
    [TestClass]
    public class TestPruebasEntidades
    {
       
        [TestMethod]
        public void ValidarListaProducto()
        {
            Pedido pedido=new Pedido();
            Assert.IsNotNull(pedido.PedidosEnPreparacion);
        }
    }
}
