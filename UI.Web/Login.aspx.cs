using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_click(object sender, EventArgs e) 
        {
            if (txtUsuario.Text.ToLower() == "admin" && this.txtClave.text == "admin")
            {
                Page.Response.Write("Ingreso ok");
            }

            else
            {
                Page.Response.Write("Usuario y/o contraseña incorrectos");
            }
        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e) 
        {
            Response.Redirect ("~/Default.aspx?msg= Es ud. Un usuario muy descuidado, deje de olvidar.")
        }
    }
}