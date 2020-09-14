using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opc = cmbMenu.SelectedItem.ToString();

            switch (opc)
            {
                case "Usuarios":
                    Usuarios usr = new Usuarios();
                    Page.Response.Redirect("Usuarios");
                    break;
                
                case "Especialidades":
                    Especialidades esp = new Especialidades();
                    Page.Response.Redirect("Especialidades");
                    break;
                case "Planes":
                    Planes plan = new Planes();
                    Page.Response.Redirect("Planes");
                    break;
                
            }

        }
    }
}