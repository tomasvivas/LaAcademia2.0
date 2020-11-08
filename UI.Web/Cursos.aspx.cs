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
    public partial class Cursos : System.Web.UI.Page
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

        CursoLogic _logic;
        private CursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursoLogic();
                }
                return _logic;
            }
        }

        private Curso Entity
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
            this.IdTxt.Text = this.Entity.ID.ToString();
            this.añocalTxt.Text = this.Entity.AnioCalendario.ToString();
            this.CupoTxt.Text = this.Entity.Cupo.ToString();
            this.idComi.SelectedValue = Entity.IDComision.ToString();
            this.idMate.SelectedValue = Entity.IDMateria.ToString();
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            formPanel.Visible = false;

        }

        private void ClearForm()
        {
            this.IdTxt.Text = string.Empty;
            this.añocalTxt.Text = string.Empty;
            this.CupoTxt.Text = string.Empty;
            this.idComi.SelectedValue = string.Empty;
            this.idMate.SelectedValue = string.Empty;

        }

        private void EnableForm(bool enable)
        {
            this.IdTxt.Enabled = enable;
            this.añocalTxt.Enabled = enable;
            this.CupoTxt.Enabled = enable;
            this.idComi.Enabled = enable;
            this.idMate.Enabled= enable;


        }

        protected void gridView_selectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.cursoGV.SelectedValue;

        }

        private void LoadEntity(Curso cur)
        {
            cur.ID = int.Parse(this.IdTxt.Text);
            cur.Cupo = int.Parse(this.CupoTxt.Text);
            cur.AnioCalendario = int.Parse(this.añocalTxt.Text);
            cur.IDMateria = int.Parse(idMate.SelectedValue);
            cur.IDComision = int.Parse(idComi.SelectedValue);
        }

        private void SaveEntity(Curso cur)
        {
            this.Logic.Save(cur);
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
            cursoGV.DataBind();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:

                    this.DeleteEntity(this.SelectedID);
                    this.formPanel.Visible = false;
                    this.cursoGV.DataBind();

                    break;
                case FormModes.Modificacion:
                    this.Entity = new Curso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.cursoGV.DataBind();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:

                    this.Entity = new Curso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.cursoGV.DataBind();
                    this.formPanel.Visible = false;
                    break;
            }
            this.formPanel.Visible = false;

        }
    }
}