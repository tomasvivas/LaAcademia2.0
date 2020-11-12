using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using UI.Desktop.FormsEntidades;

namespace UI.Desktop
{
    public partial class Cursos : Form
    {
        private Persona per;
        public Persona Per
        {
            get { return per; }
            set { per = value; }
        }

        public Cursos(Persona per)
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
            Per = per; 
            
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            this.Listar();
            if (Per.TipoPersona != Persona.TipoPersonas.Administrador)
            {
                tsbEditar.Enabled = false;
                tsbEliminar.Enabled = false;
                tsbNuevo.Enabled = false;
                tsbNotas.Visible = false;
            }


        }

        public void Listar()
        {
            CursoLogic cl = new CursoLogic();
            this.dgvCursos.DataSource = cl.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop cd = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            cd.ShowDialog();
            this.Listar();
        }

        private void tbsEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop cd = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                cd.ShowDialog();
                this.Listar();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop cd = new CursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                cd.ShowDialog();
                this.Listar();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcCursos_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void tsbNotas_Click(object sender, EventArgs e)
        {
           // try
            //{
                int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                Notas not = new Notas(ID);
                not.ShowDialog();
           // }
            //catch
            //{
            //    MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}
        }
    }
}
