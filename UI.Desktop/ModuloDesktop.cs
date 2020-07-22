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
    public partial class ModuloDesktop : ApplicationForm
    {
        private Modulo _ModuloAct;
        public Modulo ModuloActual
        {
            get { return _ModuloAct; }
            set { _ModuloAct = value; }
        }

        public ModuloDesktop()
        {
            InitializeComponent();
        }

        public ModuloDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public ModuloDesktop(string descripcion, ModoForm modo) : this()
        {
            Modo = modo;
            ModuloLogic modulo = new ModuloLogic();
            ModuloActual = modulo.GetOne(descripcion);
            this.MapearDeDatos();

        }

        private void ModuloDesktop_Load(object sender, EventArgs e)
        {

        }

        public override void MapearDeDatos()
        {
            this.txtDescripcion.Text = this.ModuloActual.Descripcion;

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
                Modulo ModuloNuevo = new Modulo();

                ModuloNuevo.Descripcion = this.txtDescripcion.Text;
                ModuloActual = ModuloNuevo;
                ModuloLogic nuevomodulo = new ModuloLogic();
                nuevomodulo.Save(ModuloActual);
            }

            else if (Modo == ModoForm.Modificacion)
            {

                ModuloActual.Descripcion = this.txtDescripcion.Text;
                ModuloActual.ID = int.Parse(this.txtID.Text);
                ModuloLogic nuevomodulo = new ModuloLogic();
                nuevomodulo.Save(ModuloActual);


            }
            else if (Modo == ModoForm.Baja)
            {
                ModuloActual.Descripcion = "";
                ModuloLogic nuevomodulo = new ModuloLogic();
                nuevomodulo.Save(ModuloActual);
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
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }


}
