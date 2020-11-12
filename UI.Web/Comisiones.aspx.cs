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
    public partial class Comisiones : System.Web.UI.Page
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

        ComisionLogic _logic;
        private ComisionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new ComisionLogic();
                }
                return _logic;
            }
        }

        private Comision Entity
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
            this.txtAnio.Text = this.Entity.AnioEspecialidad.ToString();
            this.idplan.SelectedValue = Entity.IDPlan.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            formPanel.Visible = false;
            
        }

        private void ClearForm()
        {
            this.txtID.Text = string.Empty;
            this.txtDesc.Text = string.Empty;
            this.txtAnio.Text = string.Empty;

        }

        private void EnableForm(bool enable)
        {
            this.txtID.Enabled = enable;
            this.txtDesc.Enabled = enable;
            this.txtAnio.Enabled = enable;
            

        }

        protected void gridView_selectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;

        }

        private void LoadEntity(Comision com)
        {
            com.ID = int.Parse(this.txtID.Text);
            com.Descripcion = this.txtDesc.Text;
            com.AnioEspecialidad = int.Parse(this.txtAnio.Text);
            com.IDPlan = int.Parse(idplan.SelectedValue);

        }

        private void SaveEntity(Comision com)
        {
            this.Logic.Save(com);
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        #endregion

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.Panel3.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.Panel3.Visible = true;
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
                this.Panel3.Visible = true;
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
                    this.Entity = new Comision();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.gridView.DataBind();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:

                    this.Entity = new Comision();
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