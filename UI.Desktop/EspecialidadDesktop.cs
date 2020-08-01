using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        private Especialidad _EspAct;
        public Especialidad EspecialidadActual
        {
            get { return _EspAct; }
            set { _EspAct = value; }
        }
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public EspecialidadDesktop(int id, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadLogic especialidad = new EspecialidadLogic();
            EspecialidadActual = especialidad.GetOne(id);
            this.MapearDeDatos();

        }
        public override void MapearDeDatos()
        {
            this.txtId.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;

            if (Modo == ModoForm.Alta)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            }
            else
            {
                btnAceptar.Text = "Aceptar";
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Especialidad EspecialidadNueva = new Especialidad();
                
                EspecialidadNueva.Descripcion = this.txtDescripcion.Text;
                EspecialidadActual = EspecialidadNueva;
                EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                nuevaespecialidad.Save(EspecialidadActual);
            }

            else if (Modo == ModoForm.Modificacion)
            {
                EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                nuevaespecialidad.Save(EspecialidadActual);


            }
            else if (Modo == ModoForm.Baja)
            {
               EspecialidadActual.ID = int.Parse("");
                EspecialidadActual.Descripcion = "";
               EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                nuevaespecialidad.Save(EspecialidadActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }
        public bool Validar(string descripcion)
        {
            if (descripcion.Length != 0)
            {
                return true;
            }
            else
            {
                this.Notificar("Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Descripcion = this.txtDescripcion.Text;

            if (Validar(Descripcion) == true)
            {
                this.GuardarCambios();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }

}