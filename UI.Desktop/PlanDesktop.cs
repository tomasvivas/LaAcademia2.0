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

namespace UI.Desktop
{
    public partial class PlanDesktop : Form
    {
        private Plan _PlanAct;
        public Plan PlanActual
        {
            get { return _PlanAct; }
            set { _PlanAct = value; }
        }
        public PlanDesktop()
        {
            InitializeComponent();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PlanLogic plan = new PlanLogic();
            PlanActual = plan.GetOne(ID);
            this.MapearDeDatos();

        }

        private void PlanDesktop_Load(object sender, EventArgs e)
        {

        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;
            this.txtIdEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();

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
                Plan PlanNuevo = new Plan();
                PlanNuevo.Descripcion = this.txtDescripcion.Text;
                PlanNuevo.IDEspecialidad = int.Parse(this.txtIdEspecialidad.Text); 
                PlanActual = PlanNuevo;
                PlanLogic nuevoplan = new PlanLogic();
                nuevoplan.Save(PlanActual);
            }

            else if (Modo == ModoForm.Modificacion)
            {
                PlanActual.Descripcion = this.txtDescripcion.Text;
                PlanActual.IDEspecialidad = int.Parse(this.txtIdEspecialidad.Text);
                PlanLogic nuevoplan = new PlanLogic();
                nuevoplan.Save(PlanActual);


            }
            else if (Modo == ModoForm.Baja)
            {

                PlanActual.Descripcion = "";
                PlanActual.IDEspecialidad = int.Parse("");
                PlanLogic nuevoplan = new PlanLogic();
                nuevoplan.Save(PlanActual);

            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }

        public bool Validar(string desc, int idesp)
        {
            if (desc != null && idesp != 0)
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
            string desc = this.txtDescripcion.Text;
            int idesp = int.Parse(this.txtIdEspecialidad.Text); 


            if (Validar(desc,idesp) == true)
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
