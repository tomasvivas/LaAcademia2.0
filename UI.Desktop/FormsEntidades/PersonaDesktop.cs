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
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {
        #region Propiedades
        private Business.Entities.Persona _PerAct;
        public Business.Entities.Persona PersonaActual
        {
            get { return _PerAct; }
            set { _PerAct = value; }
        }
        #endregion

        #region Constructores
        public PersonaDesktop()
        {
            InitializeComponent();
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.MapearPlanes();
            this.MapearTipoPersonas();
        }

        public PersonaDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PersonaLogic persona = new PersonaLogic();
            PersonaActual = persona.GetOne(ID);
            this.MapearDeDatos();
            this.MapearPlanes();
            this.MapearTipoPersonas();

        }

        #endregion

        #region Metodos

        public void MapearPlanes()
        {
            PersonaLogic pl = new PersonaLogic();
            cmbIDPlan.DataSource = pl.GetPlanes();
            cmbIDPlan.ValueMember = "ID";
            cmbIDPlan.DisplayMember = "Descripcion";
            if (Modo != ModoForm.Alta)
            {
                cmbIDPlan.SelectedValue = PersonaActual.IDPlan;

            };
        }

        public void MapearTipoPersonas()
        {
            cmbTipoPersona.DataSource = Enum.GetValues(typeof(Persona.TipoPersonas));

            if (Modo != ModoForm.Alta)
            {
                cmbTipoPersona.SelectedItem = PersonaActual.TipoPersona;

            }

        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PersonaActual.ID.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre;
            this.txtApellido.Text = this.PersonaActual.Apellido;
            this.txtEmail.Text = this.PersonaActual.Email;
            this.txtDireccion.Text = this.PersonaActual.Direccion;
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.txtTelefono.Text = this.PersonaActual.Telefono;
            this.txtFechaNac.Text = this.PersonaActual.FechaNacimiento.ToString();
            

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
                txtDireccion.Enabled = false;
                txtLegajo.Enabled = false;
                txtTelefono.Enabled = false;
                txtFechaNac.Enabled = false;
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Persona PersonaNueva = new Persona();

                PersonaNueva.Nombre = this.txtNombre.Text;
                PersonaNueva.Apellido = this.txtApellido.Text;
                PersonaNueva.Legajo = int.Parse(this.txtLegajo.Text);
                PersonaNueva.Direccion = this.txtDireccion.Text;
                PersonaNueva.IDPlan = Convert.ToInt32(cmbIDPlan.SelectedValue.ToString());
                PersonaNueva.TipoPersona = (Persona.TipoPersonas)Enum.Parse(typeof(Persona.TipoPersonas), cmbTipoPersona.SelectedValue.ToString());
                PersonaNueva.Email = this.txtEmail.Text;
                PersonaNueva.FechaNacimiento = Convert.ToDateTime(this.txtFechaNac.Text);
                PersonaNueva.Telefono = this.txtTelefono.Text;
                PersonaActual = PersonaNueva;
                PersonaLogic pl = new PersonaLogic();
                PersonaNueva.State = BusinessEntity.States.New;
                pl.Save(PersonaNueva);

            }

            else if (Modo == ModoForm.Modificacion)
            {

                PersonaActual.Nombre = this.txtNombre.Text;
                PersonaActual.Apellido = this.txtApellido.Text;
                PersonaActual.Direccion = this.txtDireccion.Text;
                PersonaActual.Legajo = int.Parse(txtLegajo.Text);
                PersonaActual.Email = this.txtEmail.Text;
                PersonaActual.IDPlan = Convert.ToInt32(cmbIDPlan.SelectedValue.ToString());
                PersonaActual.TipoPersona = (Persona.TipoPersonas)Enum.Parse(typeof(Persona.TipoPersonas), cmbTipoPersona.SelectedValue.ToString());
                PersonaActual.FechaNacimiento = Convert.ToDateTime(this.txtFechaNac.Text);
                PersonaActual.Telefono = this.txtTelefono.Text;

                PersonaLogic pl = new PersonaLogic();
                PersonaActual.State = BusinessEntity.States.Modified;
                pl.Save(PersonaActual);


            }
            else if (Modo == ModoForm.Baja)
            {

                PersonaLogic pl = new PersonaLogic();
                PersonaActual.State = BusinessEntity.States.Deleted;
                pl.Save(PersonaActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }

        public bool Validar(string apellido, string nombre, string email, string direc, string tel, int leg)
        {
            if (apellido.Length != 0 & nombre.Length != 0 & email.Length != 0 & email.Length != 0 & tel.Length != 0 & leg > 0)   
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
            string Telefono = this.txtTelefono.Text;
            string Direccion = this.txtDireccion.Text;
            int Legajo = int.Parse(this.txtLegajo.Text);


            if (Validar(Apellido, Nombre, Email, Direccion, Telefono, Legajo) == true)
            {
                this.GuardarCambios();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
