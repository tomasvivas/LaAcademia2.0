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
    public partial class EspecialidadesDesktop : ApplicationForm
    {
      
         private Especialidad _EspAct;
        public Especialidad EspecialidadActual
        {
            get { return _EspAct; }
            set { _EspAct = value; }
        }

        public EspecialidadesDesktop()
        {
            InitializeComponent();
        }
        public EspecialidadesDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public EspecialidadesDesktop(string descripcion, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadLogic usuario = new EspecialidadLogic();
            EspecialidadActual = usuario.GetOne(descripcion);
            this.MapearDeDatos();

        }



        private void EspecialidadDesktop_Load(object sender, EventArgs e)
        {

        }

        public override void MapearDeDatos()
        {
            this.txtdescripcion.Text = this.EspecialidadActual.Descripcion.ToString();

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
        public override bool Validar(string descripcion)
        {
            if (descripcion.Length != 0 )
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

            string descripcion = this.txtDescripcion.Text;
            


            if (Validar(descripcion) == true)
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
