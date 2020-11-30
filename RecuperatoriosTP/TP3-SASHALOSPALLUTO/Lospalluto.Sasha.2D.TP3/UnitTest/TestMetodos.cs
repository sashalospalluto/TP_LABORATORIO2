using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using ClasesInstanciables;

namespace UnitTest
{
    /// <summary>
    /// Descripción resumida de TestMetodos
    /// </summary>
    [TestClass]
    public class TestMetodos
    {       
        [TestMethod]
        public void ValidarEquals()
        {
            //Arrange
            Profesor profesor;
            Alumno alumno;
            bool respuestaDeseada = false;
            bool respuestaRecibida;

            //Act
            profesor = new Profesor(1, "Julieta", "Vicente", "40422602", Persona.ENacionalidad.Argentino);
            alumno = new Alumno(4, "Milagos", "Hernandez", "40422602", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion, Alumno.EEstadoCuenta.AlDia);

            respuestaRecibida = profesor.Equals(alumno);

            //Assert
            Assert.AreEqual(respuestaDeseada, respuestaRecibida);
        }
    }
}
