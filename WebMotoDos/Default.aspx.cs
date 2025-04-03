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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["listaMotos"] == null)
                {
                    List<Moto> lista = MotoController.obtenerMotos();

                    if(lista.Count == 0)
                    {
                        Session.Add("listaMotos",new List<Moto>());
                    }
                    else
                    {
                        Session.Add("listaMotos", lista);
                    }
                }

                repRepetidor.DataSource = Session["listaMotos"];
                repRepetidor.DataBind();
            }
            

        }

        protected void btnInformacionMoto_Click(object sender, EventArgs e)
        {

        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CatalogoCompras.aspx", false);
        }
    }
}