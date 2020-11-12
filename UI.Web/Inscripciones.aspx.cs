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
    public partial class Inscripciones : System.Web.UI.Page
    {


        #region Propiedades
        private Persona _per;
        public Persona Per
        {
            get { return _per; }
            set { _per = value; }
        }

        

        private InscripcionLogic _il;
        public InscripcionLogic il
        {
            get { return _il; }
            set { _il = value; }
        }

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
            
            

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            Curso cur = cl.GetOne(SelectedID);
            AlumnoInscripcion alum = new AlumnoInscripcion();
            alum.Condicion = "Regular";
            alum.IDAlumno = Per.ID;
            alum.IDCurso = cur.ID;
            alum.State = BusinessEntity.States.New;
            il.Save(alum);
            this.Listar();
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user = (Usuario)Session["Usuario"];
            PersonaLogic pl = new PersonaLogic();
            Per = pl.GetOne(user.ID_Persona);
            if(Per.TipoPersona == Persona.TipoPersonas.Alumno)
            {
                il = new InscripcionLogic();
                this.Listar();
            }
            else
            {
                dgInscripciones.Visible = false;
                btnNuevo.Visible = false;
                lbl.Visible = true;
            }
            
        }

        public void Listar()
        {
            dgInscripciones.DataSource = il.GetCursosAlumno(Per);
            dgInscripciones.DataBind();
        }

        public void gridView_selectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.dgInscripciones.SelectedValue;
        }
    }
}