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
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Usuario usuario = (Usuario)Session["usuario"];

                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtEmail.Text = usuario.Email;
            }

        }

        protected void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)Session["usuario"];

            usuario.Nombre = !string.IsNullOrEmpty(txtNombre.Text) ? txtNombre.Text : usuario.Nombre;
            usuario.Apellido = !string.IsNullOrEmpty(txtApellido.Text) ? txtApellido.Text : usuario.Apellido;
            usuario.Email = !string.IsNullOrEmpty(txtEmail.Text) ? txtEmail.Text : usuario.Email;
            usuario.Contraseña = !string.IsNullOrEmpty(txtContraseña.Text) ? Usuario.HashearContraseña(this.txtContraseña.Text) : usuario.Contraseña;

            UsuarioController.modificarUsuario(usuario);

            Response.Redirect("Default.aspx", false);
        }
    }
}