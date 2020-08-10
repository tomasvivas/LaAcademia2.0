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
    public partial class Login : ApplicationForm
    {
        private Usuario _UsAct;
        public Usuario UsuarioActual
        {
            get { return _UsAct; }
            set { _UsAct = value; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string clave = this.txtClave.Text;
            UsuarioLogic usr = new UsuarioLogic();
            UsuarioActual = usr.GetOne(id);
            if (UsuarioActual != null)
            {
                if (UsuarioActual.Clave == clave)
                {
                    //abrir menu
                    Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    this.Notificar("La clave no coincide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Notificar("El usuario no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
