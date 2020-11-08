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
    public partial class UsuariosReporte : Form
    {
        public UsuariosReporte()
        {
            InitializeComponent();
        }

        private void UsuariosReporte_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter1.Fill(this.academiaDataSet1.usuarios);
            this.reportViewer1.RefreshReport();
        }
    }
}
