using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Notas : System.Web.UI.Page
    {
        #region Propiedades
        InscripcionLogic _logic;
        private InscripcionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new InscripcionLogic();
                }
                return _logic;
            }
        }

        private AlumnoInscripcion Entity
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

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int idCurso = int.Parse(Request.QueryString["ID"]);
        }

        protected void btnNota_Click(object sender, EventArgs e)
        {

        }

        protected void gridView_selectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvNotas.SelectedValue;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}