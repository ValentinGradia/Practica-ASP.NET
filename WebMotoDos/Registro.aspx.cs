using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMotoDos.Controllers;
using WebMotoDos.Models;

namespace WebMotoDos
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {


            string email = this.txtEmailRegistro.Text;
            string contraseña = Usuario.HashearContraseña(this.txtContraseñaRegistro.Text);

            string nombre = this.txtName.Text;
            
            string apellido = this.txtApellido.Text;

            try
            {

                UsuarioController.verificarEmail(email);

                Usuario usuarioRegistrado = new Usuario();
                usuarioRegistrado.Email = email;
                usuarioRegistrado.Nombre = nombre;
                usuarioRegistrado.Apellido = apellido;
                usuarioRegistrado.Contraseña = contraseña;

                Session.Add("usuario", usuarioRegistrado);
                int id = UsuarioController.insertarUsuario(usuarioRegistrado);
                Response.Redirect("Default.aspx", false);

            }
            catch(MailEnUsoException ex)
            {
                this.alertRegistro.Style["display"] = "block";
                this.lblErrorLogin.Text = ex.Message;
            }
            
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string email = this.txtEmailLogin.Text;
            string contraseña = Usuario.HashearContraseña(this.txtContraseñaLogin.Text);

            try
            {
                Usuario usuario = UsuarioController.obtenerUsuario(email, contraseña);

                Session.Add("usuario", usuario);
                Response.Redirect("Default.aspx", false);
            }
            catch(UsuarioNullException ex)
            {
                this.alertSesion.Style["display"] = "block";
                this.lblErrorLogin.Text = ex.Message;
            }


        }
    }
}