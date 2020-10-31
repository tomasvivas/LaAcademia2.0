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
            // TODO: esta línea de código carga datos en la tabla 'academiaDataSet.docentes_cursos' Puede moverla o quitarla según sea necesario.
            this.docentes_cursosTableAdapter.Fill(this.academiaDataSet.docentes_cursos);
            this.Listar();

        }

        public void Listar() 
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            this.dgvDocentesCursos.DataSource = dcl.GetAll();
        }



        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            DocentesCursosDesktop cd = new DocentesCursosDesktop(ApplicationForm.ModoForm.Alta);
            cd.ShowDialog();
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
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
