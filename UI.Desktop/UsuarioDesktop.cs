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
            MapearDeDatos();
            switch (modo)
            {
                case ModoForm.Alta:
                {
                this.btnAceptar.Text = "Guardar";
                        break;
                }
                case ModoForm.Baja:
                {
                this.btnAceptar.Text = "Eliminar";
                break;
                }
                case ModoForm.Modificacion:
                {
                this.btnAceptar.Text = "Guardar";
                break;
                }
                case ModoForm.Consulta:
                {
                this.btnAceptar.Text = "Aceptar";
                break;
                }
            }

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
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave; 
               
        }
        public override void MapearADatos() 
        { 
            if (this.Modo == ModoForm.Alta)
            {
                Usuario usuario = new Usuario();
                UsuarioActual = usuario; 
            }
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                this.UsuarioActual.ID =  this.txtID.Text; 
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Nombre = this.txtNombre.Text ;
                this.txtApellido.Text = this.UsuarioActual.Apellido;
                this.txtEmail.Text = this.UsuarioActual.Email;
                this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
                this.txtClave.Text = this.UsuarioActual.Clave;
                this.txtConfirmarClave.Text = this.UsuarioActual.Clave;

            }
            if (this.Modo == ModoForm.Alta) UsuarioActual.State = BusinessEntity.States.New;
            if (this.Modo == ModoForm.Modificacion) UsuarioActual.State = BusinessEntity.States.Modified;
            
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic usuarionuevo = new UsuarioLogic();
            usuarionuevo.Save(UsuarioActual);
        }
        public override bool Validar() 
        {
            if (this.txtClave.Text == this.txtConfirmarClave.Text && this.txtClave.Text.Length <= 8 && this.txtEmail.Text.Length <= 10 && this.txtID.Text != null) return true;
            else return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar() == true) GuardarCambios();
            this.Close();  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
