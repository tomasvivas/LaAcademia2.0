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

        public Login()
        {

        }

        private Persona.TipoPersonas tipoper;

        public Persona.TipoPersonas tipoPersona
        {
            get { return tipoper; }
            set { tipoper = value; }
        }

        private int _idalum;
        public int idalum
        {
            get { return _idalum; }
            set { _idalum = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lnkError.Visible = false;
            
        }
        // txtUsuario y txtClave
        protected void btnIngresar_click(object sender, EventArgs e) 
        {
            UsuarioLogic user = new UsuarioLogic();
            Usuario usuarioActual = new Usuario();
            usuarioActual = user.GetOne(txtUsuario.Text);
             
            if(txtClave.Text.Length > 0 && txtUsuario.Text.Length > 0)
            {
                if (usuarioActual is null || (usuarioActual.Clave != txtClave.Text))
                {
                    Page.Response.Write("Usuario y/o contrasña incorrectos");
                }
                else
                {
                    Page.Response.Write("Ingreso ok");
                    Session["Usuario"] = new Usuario();
                    Session["Usuario"] = usuarioActual;
                    Page.Response.Redirect("Menu");


                    this.Dispose();
                }
            }
            else
            {
                lnkError.Visible = true;
            }


        }

        

    }
}