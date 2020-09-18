using System;
using System.Web.Http;
using System.Web.Mvc;
using ApiEstudianteSeguro.Controllers;
using ApiEstudianteSeguro.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstudianteSeguro.Tests.Controllers
{
    [TestClass]
    public class UnitTestEstudiante2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            StudentsController controller = new StudentsController();
            Student Esperado = new Student()
            {
                StudentID = 1,
                FirstName = "Enrique",
                LastName = "Arce",
                EnrollmentDate = DateTime.Today;
            }
            //act
            IHttpActionResult actionResult = controller.PostStudent(student);
            var studentresultado = StudentsController.PutStudent(studentEsperado.StudentID, studentEsperado)
            //assert
            Assert.AreEqual(studentEsperado, studentResultado)
        }
    }
}
