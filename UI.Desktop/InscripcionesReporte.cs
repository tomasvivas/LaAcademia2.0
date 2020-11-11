using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class InscripcionesReporte : Form
    {
        public InscripcionesReporte()
        {
            InitializeComponent();
        }

        private void InscripcionesReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AcademiaDataSet.alumnos_inscripciones' Puede moverla o quitarla según sea necesario.
            this.alumnos_inscripcionesTableAdapter.Fill(this.AcademiaDataSet.alumnos_inscripciones);

            this.reportViewer1.RefreshReport();
        }
    }
}
