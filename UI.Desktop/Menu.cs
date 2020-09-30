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
using UI.Desktop.FormsEntidades; 

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
                Validar(login.tipoPersona);
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
                case "Comisiones":
                    Comisiones com = new Comisiones();
                    com.Show();
                    break;
                

            }

        }

        public void Validar(Persona.TipoPersonas tipoper)
        {
            switch (tipoper)
            {

                case Persona.TipoPersonas.Profesor:
                    MessageBox.Show("Usted ha ingresado como profesor");
                    cmbMenu.Items.Remove("Especialidades");
                    break;
                case Persona.TipoPersonas.Administrador:
                    MessageBox.Show("Usted ha ingresado como administrador");
                    break;
                case Persona.TipoPersonas.Alumno:
                    MessageBox.Show("Usted ha ingresado como alumno");
                    break;
                default:
                    break;


            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporteUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosReporte ur = new UsuariosReporte();
            ur.Show();
        }
    } 
}

