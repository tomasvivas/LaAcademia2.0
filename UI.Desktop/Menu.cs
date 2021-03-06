﻿using System;
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
            userControl11.Form = this;
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
                    
                    tipo.Text = "Usted ha ingresado como " + tipoper.ToString();
                    tsbREspecialidades.Visible = false;
                    tsbInscripcion.Visible = false;
                    tsbUsuarios.Visible = false;
                    tsbPersonas.Visible = false;
                    tsbRUsuarios.Visible = false; 
                    break;
                case Persona.TipoPersonas.Administrador:
                    tipo.Text = "Usted ha ingresado como " + tipoper.ToString(); 
                    tsbInscripcion.Visible = false;
                    
                    break;
                case Persona.TipoPersonas.Alumno:
                    tipo.Text = "Usted ha ingresado como " + tipoper.ToString();
                    tsbReportes.Visible = false;
                    tsbPersonas.Visible = false;
                    tsbUsuarios.Visible = false;
                   
                    break;
                default:
                    break;


            }
        }


        

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios(PerAct);
            usr.Show();
        }

        private void tsbPersonas_Click(object sender, EventArgs e)
        {
            Personas per = new Personas(PerAct);
            per.Show();
        }

        private void tsbPlanes_Click(object sender, EventArgs e)
        {
            Planes plan = new Planes(PerAct);
            plan.Show();
        }

        private void tsbEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades(PerAct);
            esp.Show();
        }

        private void tsbMaterias_Click(object sender, EventArgs e)
        {
            Materias mts = new Materias(PerAct);
            mts.Show();
        }

        private void tsbRUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosReporte ur = new UsuariosReporte();
            ur.Show();
        }

        private void tsbREspecialidades_Click(object sender, EventArgs e)
        {
            EspecialidadesReporte esrep = new EspecialidadesReporte();
            esrep.Show();
        }

        private void tsbRCursos_Click(object sender, EventArgs e)
        {
            CursosReporte currep = new CursosReporte();
            currep.Show();
        }

        private void tsbCursos_Click(object sender, EventArgs e)
        {
            Cursos cur = new Cursos(PerAct);
            cur.Show();
        }

        private void tsbComisiones_Click(object sender, EventArgs e)
        {
            Comisiones com = new Comisiones(PerAct);
            com.Show();
        }

        private void tsbInscripciones_Click(object sender, EventArgs e)
        {
            Inscripciones ins = new Inscripciones(PerAct);
            ins.Show();
        }

        private void stbRInscripciones_Click(object sender, EventArgs e)
        {
            InscripcionesReporte insc = new InscripcionesReporte();
            insc.Show();
        }

        private void tsbRPlanes_Click(object sender, EventArgs e)
        {
            PlanesReporte prep = new PlanesReporte();
            prep.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControl11_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public void cerrarventana() 
        {
          this.Dispose();
        }
    } 
}

