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

namespace UI.Desktop
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false; 
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            PlanLogic plan = new PlanLogic();
            this.dgvPlanes.DataSource = plan.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop plan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            plan.ShowDialog();
            this.Listar();

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop formPlanes = new PlanDesktop(ID, ApplicationForm.ModoForm.Baja);
            formPlanes.ShowDialog();
            this.Listar();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop formPlanes = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formPlanes.ShowDialog();
            this.Listar();
        }
    }
}
