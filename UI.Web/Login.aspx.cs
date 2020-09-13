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
        // txtUsuario y txtClave
        protected void btnIngresar_click(object sender, EventArgs e) 
        {
            UsuarioLogic user = new UsuarioLogic();
            Usuario usuarioActual = new Usuario();
            usuarioActual = user.GetOne(txtUsuario.Text);


            if (usuarioActual is null || (usuarioActual.Clave != txtClave.Text))
            {
                this.Notificar("El usuario y/o la contraseña son incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                PersonaLogic pl = new PersonaLogic();
                Persona PersonaActual = new Persona();
                PersonaActual = pl.GetOne(usuarioActual.ID_Persona);
                tipoper = PersonaActual.TipoPersona;
                this.DialogResult = DialogResult.OK;
                this.Dispose();

            }


        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e) 
        {
            Response.Redirect("~/Default.aspx?msg= Es ud. Un usuario muy descuidado, deje de olvidar.");
        }
    }
}