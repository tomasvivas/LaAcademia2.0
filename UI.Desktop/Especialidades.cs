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
using System.Security.Cryptography.X509Certificates;

namespace UI.Desktop
{
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            this.dgvEspecialidades.AutoGenerateColumns = false;
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            EspecialidadLogic ul = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = ul.GetAll();
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbsNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadesDesktop ud = new EspecialidadesDesktop(ApplicationForm.ModoForm.Alta);
            ud.ShowDialog();
            this.Listar();
        }

        private void tbsEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows != null)
            {
                string descripcion = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).Descripcion;
                EspecialidadesDesktop ed = new EspecialidadesDesktop(descripcion, ApplicationForm.ModoForm.Modificacion);
                ed.ShowDialog();
                this.Listar();
            }
        }

        private void tbsEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows != null)
            {
                string  descripcion  = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).Descripcion;
                EspecialidadesDesktop ed = new EspecialidadesDesktop(descripcion, ApplicationForm.ModoForm.Baja);
                ed.ShowDialog();
                this.Listar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        
    }
}
