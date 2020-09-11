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
        #region Propiedades
        private Especialidad _EspAct;
        public Especialidad EspecialidadActual
        {
            get { return _EspAct; }
            set { _EspAct = value; }
        }
        #endregion

        #region Constructores
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

        #endregion

        #region Metodos
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
                EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                EspecialidadActual = EspecialidadNueva;
                EspecialidadNueva.State = BusinessEntity.States.New;
                nuevaespecialidad.Save(EspecialidadActual);
            }

            else if (Modo == ModoForm.Modificacion)
            {
                EspecialidadActual.Descripcion = this.txtDescripcion.Text;

                EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                EspecialidadActual.State = BusinessEntity.States.Modified;
                nuevaespecialidad.Save(EspecialidadActual);
            }
            else if (Modo == ModoForm.Baja)
            {
                EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                EspecialidadActual.State = BusinessEntity.States.Deleted;
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
            if (descripcion.Length > 0 && descripcion.Length < 50)
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

        private void EspecialidadDesktop_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }

}