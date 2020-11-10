using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop.FormsEntidades
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        #region Propiedades
        private Usuario _UsAct;
        public Usuario UsuarioActual
        {
            get { return _UsAct; }
            set { _UsAct = value; }
        }
        #endregion
        #region Constructores
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.MapearPersonas();
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            UsuarioLogic usuario = new UsuarioLogic();
            UsuarioActual = usuario.GetOne(ID);
            this.MapearDeDatos();
            this.MapearPersonas();

        }
        #endregion


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
                txtApellido.Enabled = false;
                txtEmail.Enabled = false;
                txtNombre.Enabled = false;
                txtUsuario.Enabled = false;
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
                UsuarioNuevo.ID_Persona = Convert.ToInt32(this.cmbLegajo.SelectedValue.ToString());
                UsuarioActual = UsuarioNuevo;
                UsuarioLogic nuevousuario = new UsuarioLogic();
                UsuarioNuevo.State = BusinessEntity.States.New;
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
                UsuarioActual.ID_Persona = Convert.ToInt32(this.cmbLegajo.SelectedValue.ToString());
                UsuarioLogic nuevousuario = new UsuarioLogic();
                UsuarioActual.State = BusinessEntity.States.Modified;
                nuevousuario.Save(UsuarioActual);
            }
            else if (Modo == ModoForm.Baja)
            {
                UsuarioLogic nuevousuario = new UsuarioLogic();
                UsuarioActual.State = BusinessEntity.States.Deleted;
                nuevousuario.Save(UsuarioActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public void MapearPersonas()
        {
            UsuarioLogic ul = new UsuarioLogic();
            cmbLegajo.DataSource = ul.GetPersonas();
            cmbLegajo.ValueMember = "ID";
            cmbLegajo.DisplayMember = "legajo";
            if (Modo != ModoForm.Alta)
            {
                cmbLegajo.SelectedValue = UsuarioActual.Legajo;
            }
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }
        public bool Validar(string apellido, string nombre, string email, string usuario, string clave, string conf)
        {
            if (apellido.Length != 0 & nombre.Length != 0 & email.Length != 0 & usuario.Length != 0 & clave.Length != 0 & clave == conf
                & clave.Length >= 8)
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

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            PersonaDesktop pd = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            pd.ShowDialog();
        }
    }
}
