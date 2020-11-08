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
    public partial class Inscripciones : Form
    {
        public Inscripciones(Persona PerAct)
        {
            InitializeComponent();
            this.dgvInscripcion.AutoGenerateColumns = false;
            
            this.Listar(PerAct);
            
            
        }

        public void Listar(Persona PerAct)
        {
            CursoLogic cur = new CursoLogic();
            dgvInscripcion.DataSource = cur.GetAll();
            //InscripcionLogic ins = new InscripcionLogic();
            //dgvInscripcion.DataSource = ins.GetCursosAlumno(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbInscribir_Click(object sender, EventArgs e)
        {
           
            AlumnoInscripcion ins = new AlumnoInscripcion();
            ins.IDCurso = ((Business.Entities.AlumnoInscripcion)this.dgvInscripcion.SelectedRows[0].DataBoundItem).IDCurso;
            ins.IDAlumno = ((Business.Entities.AlumnoInscripcion)this.dgvInscripcion.SelectedRows[0].DataBoundItem).IDAlumno;
            ins.Condicion = "Inscripto";
            ins.Nota = 0;
            ins.State = BusinessEntity.States.New;
            InscripcionLogic inslog = new InscripcionLogic();
            inslog.Save(ins);
            MessageBox.Show("La inscripcion ha sido creada concretamente"); 
        }
    }
}
