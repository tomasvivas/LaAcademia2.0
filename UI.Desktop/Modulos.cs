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

namespace UI.Desktop
{
    public partial class Modulos : Form
    {

        public Modulos()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }


        public void Listar()
        {
            ModuloLogic ul = new ModuloLogic();
            this.dgvModulos.DataSource = ul.GetAll();
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ModuloDesktop modulo = new ModuloDesktop(ApplicationForm.ModoForm.Alta);
            modulo.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvModulos.SelectedRows != null)
            {
                string descripcion = ((Business.Entities.Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).Descripcion;
                ModuloDesktop mo = new ModuloDesktop(descripcion, ApplicationForm.ModoForm.Modificacion);
                mo.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvModulos.SelectedRows != null)
            {
                string descripcion = ((Business.Entities.Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).Descripcion;
                ModuloDesktop mo = new ModuloDesktop(descripcion, ApplicationForm.ModoForm.Baja);
                mo.ShowDialog();
                this.Listar();
            }
        }
    }
}
