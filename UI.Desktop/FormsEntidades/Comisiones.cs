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
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false; 
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            
        }

        private void Listar()
        {
            ComisionLogic cl = new ComisionLogic();
            this.dgvComisiones.DataSource = cl.GetAll();
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
            ComisionDesktop cd = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            cd.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionDesktop cd = new ComisionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                cd.ShowDialog();
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
                int ID = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionDesktop cd = new ComisionDesktop(ID, ApplicationForm.ModoForm.Baja);
                cd.ShowDialog();
                this.Listar();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
