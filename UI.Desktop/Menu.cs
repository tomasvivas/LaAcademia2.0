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

        static private Persona _personaActual;

        static public Persona PerAct
        {
            get { return _personaActual; }
            set { _personaActual = value; }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Today.ToString("D"); 
            Login login = new Login();
            login.ShowDialog();
            PersonaLogic per = new PersonaLogic();
            PerAct = per.GetOne(login.idAlum);
            if (login.DialogResult != DialogResult.OK)
            {
                this.Dispose();

            }
            else
            {
                this.Opacity = 100;
                Validar(login.tipoPersona, login.idAlum);
            }
        }


        public void Validar(Persona.TipoPersonas tipoper, int idalum)
        {
            switch (tipoper)
            {

                case Persona.TipoPersonas.Profesor:
                    
                    tipo.Text = "Usted ha ingresado como profesor";
                    especialidadesToolStripMenuItem.Visible = false;
                    inscripcionToolStripMenuItem.Visible = false;
                    usuariosToolStripMenuItem.Visible = false;
                    personasToolStripMenuItem.Visible = false;
                    break;
                case Persona.TipoPersonas.Administrador:
                    txtidalum.Text = idalum.ToString();
                    tipo.Text = "Usted ha ingresado como administrador";
                    //inscripcionToolStripMenuItem.Visible = false;
                    
                    break;
                case Persona.TipoPersonas.Alumno:
                    tipo.Text = "Usted ha ingresado como alumno";
                    usuariosToolStripMenuItem.Visible = false;
                    personasToolStripMenuItem.Visible = false;
                    
                   
                    break;
                default:
                    break;


            }
        }


        

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios(PerAct);
            usr.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personas per = new Personas(PerAct);
            per.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes plan = new Planes(PerAct);
            plan.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades(PerAct);
            esp.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias mts = new Materias(PerAct);
            mts.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UsuariosReporte ur = new UsuariosReporte();
            ur.Show();
        }

        private void especialidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EspecialidadesReporte esrep = new EspecialidadesReporte();
            esrep.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursosReporte currep = new CursosReporte();
            currep.Show();
        }

        private void cursostsmi_Click(object sender, EventArgs e)
        {
            Cursos cur = new Cursos(PerAct);
            cur.Show();
        }

        private void ComisionestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comisiones com = new Comisiones(PerAct);
            com.Show();
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscripciones ins = new Inscripciones(PerAct);
            ins.Show();
        }
    } 
}

