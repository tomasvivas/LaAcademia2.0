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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios();
            usr.Show();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            Materias mts = new Materias();
            mts.Show();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            Planes plan = new Planes();
            plan.Show();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades();
            esp.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos cur = new Cursos();
            cur.Show();
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
           /* Comisiones comi = new Comisiones(); 
             comi.Show(); */
        }
    }
}
