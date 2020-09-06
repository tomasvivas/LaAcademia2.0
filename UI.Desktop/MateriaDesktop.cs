using Business.Entities;
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

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        private Materia _MatAct;
        public Materia MateriaActual
        {
            get { return _MatAct; }
            set { _MatAct = value; }
        }

        public MateriaDesktop()
        {
            InitializeComponent();
        }
        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.MapearPlanes();
        }
        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            MateriaLogic materia = new MateriaLogic();
            MateriaActual = materia.GetOne(ID);
            this.MapearDeDatos();
            this.MapearPlanes();

        }



        private void MateriaDesktop_Load(object sender, EventArgs e)
        {

        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHSSemanales.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHSTotales.Text = this.MateriaActual.HSTotales.ToString();
          

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
                txtHSSemanales.Enabled = false;
                txtHSTotales.Enabled = false;
                txtIDPlan.Enabled = false;
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
                Materia MateriaNueva = new Materia();

                MateriaNueva.Descripcion = this.txtDescripcion.Text;
                MateriaNueva.HSSemanales = int.Parse(this.txtHSSemanales.Text);
                MateriaNueva.HSTotales = int.Parse(this.txtHSTotales.Text);
                MateriaNueva.IDPlan = Convert.ToInt32(txtIDPlan.SelectedValue.ToString());
                MateriaActual = MateriaNueva;
                MateriaLogic nuevamateria = new MateriaLogic();
                nuevamateria.Save(MateriaActual);
            }

            else if (Modo == ModoForm.Modificacion)
            {

                MateriaActual.Descripcion = this.txtDescripcion.Text;
                MateriaActual.HSSemanales = int.Parse(this.txtHSSemanales.Text);
                MateriaActual.HSTotales = int.Parse(this.txtHSTotales.Text);
                MateriaActual.IDPlan = Convert.ToInt32(txtIDPlan.SelectedValue.ToString());

                MateriaLogic nuevamateria = new MateriaLogic();
                nuevamateria.Save(MateriaActual);


            }
            else if (Modo == ModoForm.Baja)
            {
                MateriaActual.Descripcion = "";
                MateriaActual.HSSemanales = int.Parse("");
                MateriaActual.HSTotales = int.Parse("");
                MateriaActual.IDPlan = int.Parse("");
                MateriaLogic nuevamateria = new MateriaLogic();
                nuevamateria.Save(MateriaActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public void MapearPlanes()
        {
            MateriaLogic ml = new MateriaLogic();
            txtIDPlan.DataSource = ml.GetPlanes();
            txtIDPlan.ValueMember = "ID";
            txtIDPlan.DisplayMember = "Descripcion";
            if (Modo != ModoForm.Alta)
            {
                txtIDPlan.SelectedValue = MateriaActual.IDPlan;

            };
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }
        public bool Validar(string desc, int hssem, int hstot)
        {
            if (desc.Length != 0 & hssem >= 0 & hstot >= 0)
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
            int hssemanales = int.Parse(this.txtHSSemanales.Text);
            int hstotales = int.Parse(this.txtHSTotales.Text);
            


            if (Validar(desc, hssemanales, hstotales) == true)
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
