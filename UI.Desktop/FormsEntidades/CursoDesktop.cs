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

namespace UI.Desktop.FormsEntidades
{
    public partial class CursoDesktop : ApplicationForm
    {
        #region Propiedades
        private Curso _CurAct;
        public Curso CursoActual
        {
            get { return _CurAct; }
            set { _CurAct = value; }
        }
        #endregion


        #region Constructores
        public CursoDesktop()
        {
            InitializeComponent();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo; 
            this.MapearMaterias();
            this.MapearComisiones();
        }

        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            CursoLogic curso = new CursoLogic();
            CursoActual = curso.GetOne(ID);
            this.MapearDeDatos();
            this.MapearMaterias();
            this.MapearComisiones();

        }
        #endregion

        #region Metodos

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CursoActual.ID.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();

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
                txtCupo.Enabled = false;
                cmbAnio.Enabled = false;
                cmbComision.Enabled = false;
                cmbMateria.Enabled = false;
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
                Curso CursoNuevo = new Curso();


                CursoNuevo.Cupo = int.Parse(this.txtCupo.Text);
                CursoNuevo.AnioCalendario = Convert.ToInt32(cmbAnio.SelectedValue);
                CursoNuevo.IDComision = Convert.ToInt32(cmbComision.SelectedValue.ToString());
                CursoNuevo.IDMateria = Convert.ToInt32(cmbMateria.SelectedValue.ToString());
                CursoActual = CursoNuevo;
                CursoLogic curLogic = new CursoLogic();
                CursoNuevo.State = BusinessEntity.States.New;
                curLogic.Save(CursoNuevo);

            }

            else if (Modo == ModoForm.Modificacion)
            {

                CursoActual.Cupo = int.Parse(this.txtCupo.Text);
                CursoActual.AnioCalendario = Convert.ToInt32(cmbAnio.SelectedValue);
                CursoActual.IDComision = Convert.ToInt32(cmbComision.SelectedValue.ToString());
                CursoActual.IDMateria = Convert.ToInt32(cmbMateria.SelectedValue.ToString());
                CursoLogic cl = new CursoLogic();
                CursoActual.State = BusinessEntity.States.Modified;
                cl.Save(CursoActual);
            }
            else if (Modo == ModoForm.Baja)
            {

                CursoLogic cl = new CursoLogic();
                CursoActual.State = BusinessEntity.States.Deleted;
                cl.Save(CursoActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public void MapearMaterias()
        {
            CursoLogic cl = new CursoLogic();
            cmbMateria.DataSource = cl.GetMaterias();
            cmbMateria.ValueMember = "ID";
            cmbMateria.DisplayMember = "Descripcion";
            if (Modo != ModoForm.Alta)
            {
                cmbMateria.SelectedValue = CursoActual.IDMateria;

            };
        }

        public void MapearComisiones()
        {
            CursoLogic cl = new CursoLogic();
            cmbComision.DataSource = cl.GetComisiones();
            cmbComision.ValueMember = "ID";
            cmbComision.DisplayMember = "Descripcion";
            if (Modo != ModoForm.Alta)
            {
                cmbComision.SelectedValue = CursoActual.IDComision;

            };
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
        }

        public bool Validar(int cupo)
        {
            if (cupo >= 0)
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

            int cupo = int.Parse(this.txtCupo.Text);


            if (Validar(cupo) == true)
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
