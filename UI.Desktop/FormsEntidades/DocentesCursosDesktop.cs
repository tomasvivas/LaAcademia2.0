using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop.FormsEntidades
{
    public partial class DocentesCursosDesktop : ApplicationForm
    {
        #region Propiedades
        private DocenteCurso _DocCurAct;
        public DocenteCurso DocenteCursoActual
        {
            get { return _DocCurAct; }
            set { _DocCurAct = value; }
        }
        #endregion

        #region Constructores
        public DocentesCursosDesktop()
        {
            InitializeComponent();
        }
        public DocentesCursosDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.MapearCursos();
            this.MapearDocentes();
        }

        public DocentesCursosDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            DocenteCursoLogic curso = new DocenteCursoLogic();
            DocenteCursoActual = curso.GetOne(ID);
            this.MapearDeDatos();
            this.MapearCursos();
            this.MapearDocentes();

        }
        #endregion

        #region Metodos
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                DocenteCurso DocenteCursoNuevo = new DocenteCurso();


                DocenteCursoNuevo.IDDocente = Convert.ToInt32(cmbDocentes.SelectedValue.ToString());
                DocenteCursoNuevo.IDCurso = Convert.ToInt32(cmbCursos.SelectedValue.ToString());
                DocenteCursoNuevo.Cargo = (DocenteCurso.TiposCargos)Enum.Parse(typeof(DocenteCurso.TiposCargos), cmbCargos.SelectedValue.ToString());
                DocenteCursoActual = DocenteCursoNuevo;
                DocenteCursoLogic doccurLogic = new DocenteCursoLogic();
                DocenteCursoNuevo.State = BusinessEntity.States.New;
                doccurLogic.Save(DocenteCursoNuevo);

            }

            else if (Modo == ModoForm.Modificacion)
            {

                DocenteCursoActual.IDDocente = Convert.ToInt32(cmbDocentes.SelectedValue.ToString());
                DocenteCursoActual.IDCurso = Convert.ToInt32(cmbCursos.SelectedValue.ToString());
                DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)Enum.Parse(typeof(DocenteCurso.TiposCargos), cmbCargos.SelectedValue.ToString());
                DocenteCursoLogic dcl = new DocenteCursoLogic();
                DocenteCursoActual.State = BusinessEntity.States.Modified;
                dcl.Save(DocenteCursoActual);
            }
            else if (Modo == ModoForm.Baja)
            {

                DocenteCursoLogic dcl = new DocenteCursoLogic();
                DocenteCursoActual.State = BusinessEntity.States.Deleted;
                dcl.Save(DocenteCursoActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public void MapearCursos()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            cmbCursos.DataSource = dcl.GetCursos();
            cmbCursos.ValueMember = "ID";
            cmbCursos.DisplayMember = "DescMateria";
            if (Modo != ModoForm.Alta)
            {
                cmbCursos.SelectedValue = DocenteCursoActual.IDCurso;

            };
        }


        public void MapearDocentes()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            cmbDocentes.DataSource = dcl.GetDocente();
            cmbDocentes.ValueMember = "ID";
            cmbDocentes.DisplayMember = "Apellido";
            if (Modo != ModoForm.Alta)
            {
                cmbDocentes.SelectedValue = DocenteCursoActual.IDDocente;

            };
        }
        
        public override void GuardarCambios()
        {
            this.MapearADatos();
        }

       #endregion
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
