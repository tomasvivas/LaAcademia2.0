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
            InsLog = new InscripcionLogic();
            personaActual = PerAct;
            this.Listar(PerAct);
            
            
        }

        private Persona _personaActual;
        public Persona personaActual
        {
            get { return _personaActual; }
            set { _personaActual = value; }
        }

        private InscripcionLogic _il;

        public InscripcionLogic InsLog
        {
            get { return _il; }
            set { _il = value; }
        }

        public void Listar(Persona PerAct)
        {
            dgvInscripcion.DataSource = InsLog.GetCursosAlumno(personaActual);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbInscribir_Click(object sender, EventArgs e)
        {

            Curso cur = (Curso)dgvInscripcion.SelectedRows[0].DataBoundItem;
            AlumnoInscripcion ai = new AlumnoInscripcion();
            ai.Condicion = "Inscripto";
            ai.IDAlumno = personaActual.ID;
            ai.IDCurso = cur.ID;
        }
    }
}
