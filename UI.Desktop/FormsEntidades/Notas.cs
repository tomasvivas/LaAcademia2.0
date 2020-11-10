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
    public partial class Notas : Form
    {
        public Notas(int idcur)
        {
            InitializeComponent();
            CursoLogic cl = new CursoLogic();
            cur = cl.GetOne(idcur);
            this.dgvNotas.AutoGenerateColumns = false;
            this.Listar();
        }

        private Curso _cur;
        public Curso cur
        {
            get { return _cur; }
            set { _cur = value; ; }
        }

        

        public void Listar()
        {
            InscripcionLogic ins = new InscripcionLogic();
            this.dgvNotas.DataSource = ins.GetAll(cur.ID);
        }

        private void tsbIngresarNota_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.AlumnoInscripcion)this.dgvNotas.SelectedRows[0].DataBoundItem).ID;
                NotasDesktop cd = new NotasDesktop(ID);
                cd.ShowDialog();
                this.Listar();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
