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
    public partial class PlanDesktop : ApplicationForm
    {
        #region Propiedades
        private Plan _PlanAct;
        public Plan PlanActual
        {
            get { return _PlanAct; }
            set { _PlanAct = value; }
        }
        #endregion

        #region Constructores
        public PlanDesktop()
        {
            InitializeComponent();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.MapearEspecialidades();
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PlanLogic plan = new PlanLogic();
            PlanActual = plan.GetOne(ID);
            this.MapearDeDatos();
            this.MapearEspecialidades();

        }
        #endregion
        private void PlanDesktop_Load(object sender, EventArgs e)
        {

        }

        #region Metodos
        public override void MapearDeDatos()
        {

            txtID.Text = this.PlanActual.ID.ToString();
            txtDescripcion.Text = this.PlanActual.Descripcion;

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
                txtID.Enabled = false;
                txtDescripcion.Enabled = false;
                cbEspecialidades.Enabled = false;

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
                PlanNuevo.IDEspecialidad = Convert.ToInt32(this.cbEspecialidades.SelectedValue.ToString());
                PlanLogic nuevoplan = new PlanLogic();
                PlanActual = PlanNuevo;
                PlanNuevo.State = BusinessEntity.States.New;
                nuevoplan.Save(PlanActual);
            }

            else if (Modo == ModoForm.Modificacion)
            {
                PlanActual.Descripcion = this.txtDescripcion.Text;
                PlanActual.IDEspecialidad = Convert.ToInt32(this.cbEspecialidades.SelectedValue.ToString());
                PlanLogic nuevoplan = new PlanLogic();
                PlanActual.State = BusinessEntity.States.Modified;
                nuevoplan.Save(PlanActual);
            }
            else if (Modo == ModoForm.Baja)
            {
                PlanLogic nuevoplan = new PlanLogic();
                PlanActual.State = BusinessEntity.States.Deleted;
                nuevoplan.Save(PlanActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public void MapearEspecialidades()
        {
            PlanLogic p1 = new PlanLogic();
            cbEspecialidades.DataSource = p1.GetEspecialidad();
            cbEspecialidades.ValueMember = "ID";
            cbEspecialidades.DisplayMember = "Descripcion";
            if (Modo != ModoForm.Alta)
            {
                cbEspecialidades.SelectedValue = PlanActual.IDEspecialidad;
            }
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }

        public bool Validar(string desc)
        {
            if (desc.Length > 0 & desc.Length < 50)
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
            

            if (Validar(desc) == true)
            {
                this.GuardarCambios();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
