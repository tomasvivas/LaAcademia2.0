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

namespace UI.Desktop.FormsEntidades
{
    public partial class NotasDesktop : Form
    {
        public NotasDesktop(int id)
        {
            InitializeComponent();
            InscripcionLogic ins = new InscripcionLogic();
            AlumAct = ins.GetOne(id);
        }

        private AlumnoInscripcion _al;
        public AlumnoInscripcion AlumAct
        {
            get { return _al; }
            set { _al = value; }
        }

        private void btnAcepat_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtNota.Text) > 0 && int.Parse(txtNota.Text) <= 10)
            {
                AlumAct.Nota = int.Parse(txtNota.Text);
                if(int.Parse(txtNota.Text) >= 6)
                {
                    AlumAct.Condicion = "Aprobado";
                }
                else
                {
                    AlumAct.Condicion = "Desaprobado";
                }
                AlumAct.State = BusinessEntity.States.Modified;
                InscripcionLogic ins = new InscripcionLogic();
                ins.Save(AlumAct);
                MessageBox.Show("La nota fue subida correctamente", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
