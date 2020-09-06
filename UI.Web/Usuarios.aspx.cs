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
    public partial class Usuarios : System.Web.UI.Page
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

        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }

        private Usuario Entity
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
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.Email;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();

        }

        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
            this.nombreUsuarioTextBox.Text = string.Empty;
        }

        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.nombreUsuarioTextBox.Enabled = enable;
            this.claveTextbox.Visible = enable;
            this.claveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
        }

        protected void gridView_selectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadEntity(Usuario usuario)
        {
            usuario.Nombre = this.nombreTextBox.Text;
            usuario.Apellido = this.apellidoTextBox.Text;
            usuario.Email = this.emailTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Clave = this.claveTextbox.Text;
        }

        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    if (ValidarClave() == true)
                    {
                        this.DeleteEntity(this.SelectedID);
                        this.formPanel.Visible = false;
                        this.gridView.DataBind();
                    }
                    else
                    {
                        string script = "alert(\"La clave no es la misma\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }

                    break;
                case FormModes.Modificacion:
                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    if (ValidarClave() == true)
                    {
                        this.SaveEntity(this.Entity);
                        this.gridView.DataBind();
                        this.formPanel.Visible = false;
                    }
                    else
                    {
                        string script = "alert(\"La clave no es la misma\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    break;
                case FormModes.Alta:
                    if (ValidarClave() == true)
                    {
                        this.Entity = new Usuario();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.gridView.DataBind();
                        this.formPanel.Visible = false;
                    }
                    else
                    {
                        string script = "alert(\"La clave no es la misma\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    break;
            }
            this.formPanel.Visible = false;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true); 
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
            gridView.DataBind();
        }

        public bool ValidarClave()
        {
            if (this.claveTextbox.Text != this.repetirClaveTextBox.Text)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}