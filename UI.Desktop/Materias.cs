using Business.Logic;
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

namespace UI.Desktop
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            this.dgvMaterias.DataSource = ml.GetAll();
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
            MateriaDesktop md = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            md.ShowDialog();
            this.Listar();
        }

        private void tbsEditar_Click(object sender, EventArgs e)
        {
            
                int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop md = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                md.ShowDialog();
                this.Listar();
            
        }

        private void tbsEliminar_Click(object sender, EventArgs e)
        {
                int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop md = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
                md.ShowDialog();
                this.Listar();
            
        }
    }
}
