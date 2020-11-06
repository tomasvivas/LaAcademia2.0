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
    public partial class Materias : System.Web.UI.Page
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

        MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new MateriaLogic();
                }
                return _logic;
            }
        }

        private Materia Entity
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
            this.txtID.Text = this.Entity.ID.ToString();
            this.txtDesc.Text = this.Entity.Descripcion.ToString();
            this.txtHsSemanales.Text = this.Entity.HSSemanales.ToString();
            this.txtHsTotales.Text = this.Entity.HSTotales.ToString();
            this.idplan.SelectedValue = this.Entity.IDPlan.ToString();
           
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            formPanel.Visible = false; 
        }

        private void ClearForm()
        {
            this.txtID.Text = string.Empty;
            this.txtDesc.Text = string.Empty;
            this.txtHsSemanales.Text = string.Empty;
            this.txtHsTotales.Text = string.Empty;
            
            

        }

        private void EnableForm(bool enable)
        {
            this.txtID.Enabled = enable;
            this.txtDesc.Enabled = enable;
            this.txtHsSemanales.Enabled = enable;
            this.txtHsTotales.Enabled = enable;
            

        }

        protected void gridView_selectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;

        }

        private void LoadEntity(Materia materia)
        {
            materia.ID = int.Parse(this.txtID.Text);
            materia.Descripcion = this.txtDesc.Text;
            materia.HSSemanales = int.Parse(this.txtHsSemanales.Text);
            materia.HSTotales = int.Parse(this.txtHsTotales.Text);
            materia.IDPlan = int.Parse(this.idplan.SelectedValue);
            

        }

        private void SaveEntity(Materia materia)
        {
            this.Logic.Save(materia);
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        #endregion

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);

        }

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
                    this.Entity = new Materia();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.gridView.DataBind();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:

                    this.Entity = new Materia();
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