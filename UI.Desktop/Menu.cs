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

        private void Menu_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
            {
                this.Dispose();

            }
            else
            {
                this.Opacity = 100;
            }
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opc = cmbMenu.SelectedItem.ToString();

            switch (opc)
            {
                case "Usuarios":
                    Usuarios usr = new Usuarios();
                    usr.Show();
                    break;
                case "Personas":
                    Personas per = new Personas();
                    per.Show();
                    break;
                case "Especialidades":
                    Especialidades esp = new Especialidades();
                    esp.Show();
                    break;
                case "Planes":
                    Planes plan = new Planes();
                    plan.Show();
                    break;
                case "Materias":
                    Materias mts = new Materias();
                    mts.Show();
                    break;
                case "Cursos":
                    Cursos cur = new Cursos();
                    cur.Show();
                    break;

            }

        }

        
    } 
}

