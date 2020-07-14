using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario _UsAct;
        public Usuario UsuarioActual
        {
            get { return _UsAct; }
            set { _UsAct = value; }
        }

        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            UsuarioLogic usuario = new UsuarioLogic();
            UsuarioActual = usuario.GetOne(ID);
            this.MapearDeDatos();
            
         }

    

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;

            if (Modo == ModoForm.Alta)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            }
            else
            {
                btnAceptar.Text = "Aceptar";
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Usuario UsuarioNuevo = new Usuario();


                UsuarioNuevo.Habilitado = this.chkHabilitado.Checked;
                UsuarioNuevo.Nombre = this.txtNombre.Text;
                UsuarioNuevo.Apellido = this.txtApellido.Text;
                UsuarioNuevo.Email = this.txtEmail.Text;
                UsuarioNuevo.Clave = this.txtClave.Text;
                UsuarioNuevo.NombreUsuario = this.txtUsuario.Text;
                UsuarioActual = UsuarioNuevo;
                UsuarioLogic nuevousuario = new UsuarioLogic();
                nuevousuario.Save(UsuarioActual);



            }

            else if (Modo == ModoForm.Modificacion)
            {

                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                UsuarioActual.Nombre = this.txtNombre.Text;
                UsuarioActual.Apellido = this.txtApellido.Text;
                UsuarioActual.Email = this.txtEmail.Text;
                UsuarioActual.Clave = this.txtClave.Text;
                UsuarioActual.NombreUsuario = this.txtUsuario.Text;

                UsuarioLogic nuevousuario = new UsuarioLogic();
                nuevousuario.Save(UsuarioActual);


            }
            else if (Modo == ModoForm.Baja)
            {
                UsuarioActual.Habilitado = false;
                UsuarioActual.Nombre = "";
                UsuarioActual.Apellido = "";
                UsuarioActual.Email = "";
                UsuarioActual.Clave = "";
                UsuarioActual.NombreUsuario = "";
                UsuarioLogic nuevousuario = new UsuarioLogic();
                nuevousuario.Save(UsuarioActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }
        public override bool Validar(string apellido, string nombre, string email, string usuario, string clave, string conf)
        {
            if (apellido.Length != 0 & nombre.Length != 0 & email.Length != 0 & usuario.Length != 0 & clave.Length != 0 & clave == conf
                & clave.Length <= 8)
            {
                return true;
            }
            else
            {
                this.Notificar("Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string Apellido = this.txtApellido.Text;
            string Nombre = this.txtNombre.Text;
            string Email = this.txtEmail.Text;
            string NombreUsuario = this.txtUsuario.Text;
            string Clave = this.txtClave.Text;
            string Conf = this.txtConfirmarClave.Text;


            if (Validar(Apellido, Nombre, Email, NombreUsuario, Clave, Conf) == true)
            {
                this.GuardarCambios();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
