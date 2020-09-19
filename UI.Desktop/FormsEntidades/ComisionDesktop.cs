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

namespace UI.Desktop.FormsEntidades
{
    public partial class ComisionDesktop : ApplicationForm
    {
        #region Propiedades
        private Comision _ComAct;
        public Comision ComisionActual
        {
            get { return _ComAct; }
            set { _ComAct = value; }
        }
        #endregion
        #region Constructores

        public ComisionDesktop()
        {
            InitializeComponent();
        }
        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.MapearPlanes();
        }
        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ComisionLogic comision = new ComisionLogic();
            ComisionActual = comision.GetOne(ID);
            this.MapearDeDatos();
            this.MapearPlanes();

        }
        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;        


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
                cmbAnioEspe.Enabled = false;
                cmbPlanes.Enabled = false;
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
                Comision ComisionNueva = new Comision();


                ComisionNueva.Descripcion = this.txtDescripcion.Text;
                ComisionNueva.IDPlan = Convert.ToInt32(cmbPlanes.SelectedValue.ToString());
                ComisionNueva.AnioEspecialidad = Convert.ToInt32(cmbAnioEspe.SelectedValue);
                ComisionActual = ComisionNueva;
                ComisionLogic cl = new ComisionLogic();
                ComisionNueva.State = BusinessEntity.States.New;
                cl.Save(ComisionNueva);
            }

            else if (Modo == ModoForm.Modificacion)
            {

                ComisionActual.Descripcion = this.txtDescripcion.Text;
                ComisionActual.IDPlan = Convert.ToInt32(cmbPlanes.SelectedValue.ToString());
                ComisionActual.AnioEspecialidad = Convert.ToInt32(cmbAnioEspe.SelectedValue.ToString());
                ComisionLogic cl = new ComisionLogic();
                ComisionActual.State = BusinessEntity.States.Modified;
                cl.Save(ComisionActual);
            }
            else if (Modo == ModoForm.Baja)
            {
                ComisionLogic cl = new ComisionLogic();
                ComisionActual.State = BusinessEntity.States.Deleted;
                cl.Save(ComisionActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public void MapearPlanes()
        {
            ComisionLogic cl = new ComisionLogic();
            cmbPlanes.DataSource = cl.GetPlanes();
            cmbPlanes.ValueMember = "ID";
            cmbPlanes.DisplayMember = "Descripcion";
            if (Modo != ModoForm.Alta)
            {
                cmbPlanes.SelectedValue = ComisionActual.IDPlan;

            };
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }

        public bool Validar(string desc, int anio, int idplan)
        {
            if (desc.Length != 0 & anio != 0 & idplan != 0)
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
            int anio = Convert.ToInt32(this.cmbAnioEspe.SelectedValue);
            int idplan = Convert.ToInt32(this.cmbPlanes.SelectedValue);



            if (Validar(desc, anio, idplan) == true)
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
