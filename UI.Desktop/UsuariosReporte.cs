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
            // TODO: esta línea de código carga datos en la tabla 'DataSetAcademia.usuarios' Puede moverla o quitarla según sea necesario.

            this.usuarioTableAdapter.Fill(this.DataSetAcademia.usuarios);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
