using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Desktop.FormsEntidades
{
    public partial class DocentesCursos : Form
    {
        public DocentesCursos()
        {
            InitializeComponent();
            this.dgvDocentesCursos.AutoGenerateColumns = false;
        }

        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            this.Listar();

        }

        public void Listar() 
        {
            CursoLogic cl = new CursoLogic();
            this.dgvDocentesCursos.DataSource = cl.GetAll();
        }



        

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            DocentesCursosDesktop cd = new DocentesCursosDesktop(ApplicationForm.ModoForm.Alta);
            cd.ShowDialog();
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DocenteCurso DocenteCursoNuevo = new DocenteCurso();
            DocenteCursoNuevo.IDDocente = Convert.ToInt32(dgvDocentesCursos.SelectedValue.ToString());
            DocenteCursoNuevo.IDCurso = ((Business.Entities.Curso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
            DocenteCursoNuevo.Cargo = (DocenteCurso.TiposCargos)Enum.Parse(typeof(DocenteCurso.TiposCargos), cmbCargos.SelectedValue.ToString());
            DocenteCursoActual = DocenteCursoNuevo;
            DocenteCursoLogic doccurLogic = new DocenteCursoLogic();
            DocenteCursoNuevo.State = BusinessEntity.States.New;
            doccurLogic.Save(DocenteCursoNuevo);
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
                DocentesCursosDesktop dcd = new DocentesCursosDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                dcd.ShowDialog();
                this.Listar();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
                DocentesCursosDesktop dcd = new DocentesCursosDesktop(ID, ApplicationForm.ModoForm.Baja);
                dcd.ShowDialog();
                this.Listar();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
