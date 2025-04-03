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
        public void EmailContrase�aIncorrecta_DeberiaRetornarExceptionTipoUsuarioNull()
        {
            //Arrange
            string email = "admin@admin.com"; //Email valido
            string contrase�a = Usuario.HashearContrase�a("12");

            //Act
            _ = UsuarioController.obtenerUsuario(email, contrase�a);
        }

        [TestMethod]
        public void VerificarRegistro_DeberiaRetornarUsuario()
        {
            //Arrange
            string email = "admin@admin.com";
            string contrase�a = Usuario.HashearContrase�a("1234");

            //Act

            Usuario usuario = UsuarioController.obtenerUsuario(email, contrase�a);

            //Assert
            Assert.IsInstanceOfType(usuario, typeof(Usuario));


        }
    }
}