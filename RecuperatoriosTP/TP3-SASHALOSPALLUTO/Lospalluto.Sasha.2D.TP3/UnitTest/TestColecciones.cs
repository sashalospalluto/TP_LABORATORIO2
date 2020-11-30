using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using EntidadesAbstractas;

//private List<Alumno> alumnos;
//private List<Jornada> jornadas;
//private List<Profesor> profesores;

namespace UnitTest
{
    /// <summary>
    /// Descripción resumida de TestColecciones
    /// </summary>
    [TestClass]
    public class TestColecciones
    {       
        [TestMethod]
        public void ValidarColeccionAlumnosDeUniversidad()
        {
            //arrange
            Universidad universidad;
            //act
            universidad = new Universidad();
            //assert
            Assert.IsNotNull(universidad.Alumnos);
        }

        [TestMethod]
        public void ValidarColeccionJornadasDeUniversidad()
        {
            //arrange
            Universidad universidad;
            //act
            universidad = new Universidad();
            //assert
            Assert.IsNotNull(universidad.Jornadas);
        }

        [TestMethod]
        public void ValidarColeccionProfesoresDeUniversidad()
        {
            //arrange
            Universidad universidad;
            //act
            universidad = new Universidad();
            //assert
            Assert.IsNotNull(universidad.Instructores);
        }               
    }
}
