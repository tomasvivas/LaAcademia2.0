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
    public partial class DocentesCursos : System.Web.UI.Page
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

        DocenteCursoLogic _logic;
        private DocenteCursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new DocenteCursoLogic();
                }
                return _logic;
            }
        }

        private DocenteCurso Entity
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
            this.IDDocenteTextBox.Text = this.Entity.IDDocente.ToString();
            this.CargoTextBox.Text = this.Entity.Cargo.ToString();
            this.CursoTextBox.Text = this.Entity.IDCurso.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            this.IDTextBox.Text = string.Empty;
            this.IDDocenteTextBox.Text = string.Empty;
            this.CargoTextBox.Text = string.Empty;
            this.CursoTextBox.Text = string.Empty;

        }

        private void EnableForm(bool enable)
        {
            this.IDTextBox.Enabled = enable;
            this.IDDocenteTextBox.Enabled = enable;
            this.CursoTextBox.Enabled = enable;
            this.CargoTextBox.Enabled = enable;

        }

        protected void gridView_selectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;

        }

        private void LoadEntity(DocenteCurso docentecurso)
        {
            docentecurso.ID = int.Parse(this.IDTextBox.Text);
            docentecurso.IDDocente = int.Parse(this.IDDocenteTextBox.Text);
            //docentecurso.Cargo = (this.CargoTextBox.Text);
            docentecurso.IDCurso = int.Parse(this.CursoTextBox.Text);

        }

        private void SaveEntity(DocenteCurso docentecurso)
        {
            this.Logic.Save(docentecurso);
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
                    this.Entity = new DocenteCurso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.gridView.DataBind();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:

                    this.Entity = new DocenteCurso();
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