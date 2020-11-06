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
    public partial class Personas : System.Web.UI.Page
    {
        #region Enum
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion

        }
         #endregion

        #region Propiedades
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

       
        PersonaLogic _logic;
        private PersonaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PersonaLogic();
                }
                return _logic;
            }
        }

        private Persona Entity
        {
            get;
            set;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool isEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }
        #endregion

        #region Metodos
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.IDTextBox.Text = this.Entity.ID.ToString();
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.Email;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.fechNacTextBox.Text = this.Entity.FechaNacimiento.ToString();
            this.idplan.SelectedValue = this.Entity.IDPlan.ToString();
            this.tipoper.SelectedValue = this.Entity.TipoPersona.ToString();
            this.direccionTextBox.Text = this.Entity.Direccion;
            this.txtLegajo.Text = this.Entity.Legajo.ToString();
          
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            tipoper.Items.Add("Profesor");
            tipoper.Items.Add("Administrador");
            tipoper.Items.Add("Alumno");
            formPanel.Visible = false;
        }


        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.txtLegajo.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
            this.fechNacTextBox.Text = string.Empty;
          
        }

        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.direccionTextBox.Enabled = enable;
            this.fechNacTextBox.Enabled = enable;
            this.telefonoTextBox.Enabled = enable;
            this.txtLegajo.Enabled = enable;



        }

        protected void gridView_selectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadEntity(Persona persona)
        {
            persona.Nombre = this.nombreTextBox.Text;
            persona.Apellido = this.apellidoTextBox.Text;
            persona.Email = this.emailTextBox.Text;
            persona.FechaNacimiento = Convert.ToDateTime(this.fechNacTextBox);
            persona.IDPlan = int.Parse(this.idplan.SelectedValue);
            persona.TipoPersona = (Persona.TipoPersonas)Enum.Parse(typeof(Persona.TipoPersonas), tipoper.SelectedValue.ToString());
            persona.Direccion = this.direccionTextBox.Text;
            persona.Legajo = int.Parse(this.txtLegajo.Text);
            persona.Telefono = this.telefonoTextBox.Text;
        }

        private void SaveEntity(Persona persona)
        {
            this.Logic.Save(persona);
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }


        #endregion

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
            gridView.DataBind();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                   
                        this.DeleteEntity(this.SelectedID);
                        this.formPanel.Visible = false;
                        this.gridView.DataBind();
      

                    break;
                case FormModes.Modificacion:
                    this.Entity = new Persona();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.gridView.DataBind();
                    this.formPanel.Visible = false;
                    
                    break;
                case FormModes.Alta:
                        this.Entity = new Persona();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.gridView.DataBind();
                        this.formPanel.Visible = false;
                    
                    break;
            }
            this.formPanel.Visible = false;
        }
    }


}

