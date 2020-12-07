using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Entidades;
using System.Collections.Generic;

//TEMA 16
namespace TestUnitarios
{
    [TestClass]
    public class Excepciones
    {
        [TestMethod]
        [ExpectedException(typeof(GustosException))]
        public void GustosException()
        {            
            //arrange
            //Carrito miCarrito = new Carrito("Luis");

            //act
            //List<Producto.GustoHelado> gustos = new List<Producto.GustoHelado>();
            //gustos.Add(Producto.GustoHelado.frutilla);
            //gustos.Add(Producto.GustoHelado.Granizado);

            //assert
            Torta productoTorta = new Torta();            
            productoTorta.TamanioElegido = Torta.Tamanio.Individual;
            productoTorta += Producto.GustoHelado.Americana;
            productoTorta += Producto.GustoHelado.Chocolate;
            productoTorta += Producto.GustoHelado.frutilla;

            //miCarrito += productoTorta;
            //miCarrito.CalcularTotal();

            //Carrito.Guardar(miCarrito);
            //pedido += miCarrito;

        }
    }
}
