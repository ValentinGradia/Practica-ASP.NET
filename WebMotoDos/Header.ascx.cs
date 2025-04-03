using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMotoDos.Models;

namespace WebMotoDos
{
    public partial class Header1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["usuario"] !=  null)
                {
                    lblUsuario.Text = ((Usuario)Session["usuario"]).Nombre;
                    perfilLink.NavigateUrl = "Perfil.aspx";
                }
            }


        }
    }
}