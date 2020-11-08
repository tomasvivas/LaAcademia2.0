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
    public partial class EspecialidadesReporte : Form
    {
        public EspecialidadesReporte()
        {
            InitializeComponent();
        }

        private void EspecialidadesReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AcademiaDataSet.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.AcademiaDataSet.especialidades);
            this.reportViewer1.RefreshReport();
        }
    }
}
