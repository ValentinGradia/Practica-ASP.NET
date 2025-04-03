using WebMotoDos.Controllers;
using WebMotoDos.Models;

namespace TestsUnitarios
{
    [TestClass]
    public class TestBBDD
    {
        [TestMethod]
        [ExpectedException(typeof(MailEnUsoException))]
        public void TestearEmailRepetido_DeberiaRetornarExceptionTipoMailEnUso()
        {
            //Arrange

            string email = "hola@gmail.com";

            //Act
            UsuarioController.verificarEmail(email);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioNullException))]
        public void EmailContraseñaIncorrecta_DeberiaRetornarExceptionTipoUsuarioNull()
        {
            //Arrange
            string email = "admin@admin.com"; //Email valido
            string contraseña = Usuario.HashearContraseña("12");

            //Act
            _ = UsuarioController.obtenerUsuario(email, contraseña);
        }

        [TestMethod]
        public void VerificarRegistro_DeberiaRetornarUsuario()
        {
            //Arrange
            string email = "admin@admin.com";
            string contraseña = Usuario.HashearContraseña("1234");

            //Act

            Usuario usuario = UsuarioController.obtenerUsuario(email, contraseña);

            //Assert
            Assert.IsInstanceOfType(usuario, typeof(Usuario));


        }
    }
}