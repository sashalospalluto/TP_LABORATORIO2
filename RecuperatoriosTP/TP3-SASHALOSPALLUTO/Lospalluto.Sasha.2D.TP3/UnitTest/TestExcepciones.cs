using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesAbstractas;
using ClasesInstanciables;

namespace UnitTest
{
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void ValidarDni()
        {
            //arrange
            Alumno a1 = null;
            //act
            a1 = new Alumno(1, "Martina", "Guni", "unnumero1", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void ValidarNacionalidadConDni()
        {
            //arrange
            Alumno a1 = null;
            //act
            a1 = new Alumno(1, "Ricardo", "Mendez", "40422602", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            //assert
        }


    }
}
