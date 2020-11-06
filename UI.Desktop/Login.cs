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

        private Persona.TipoPersonas tipoper;

        public Persona.TipoPersonas tipoPersona
        {
            get { return tipoper; }
            set { tipoper = value; }
        }

        private int _idAlum;

        public int idAlum
        {
            get { return _idAlum; }
            set { _idAlum = value; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtClave.PasswordChar = '*'; 
        }

        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic user = new UsuarioLogic();
            Usuario usuarioActual = new Usuario();
            usuarioActual = user.GetOne(txtUsuario.Text);
            

            if (usuarioActual is null || (usuarioActual.Clave != txtClave.Text))
            {
                this.Notificar("El usuario y/o la contraseña son incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                PersonaLogic pl = new PersonaLogic();
                Persona PersonaActual = new Persona();
                PersonaActual = pl.GetOne(usuarioActual.ID_Persona);
                PersonaActual = pl.GetOne(usuarioActual.ID);
                tipoper = PersonaActual.TipoPersona;
                idAlum = PersonaActual.ID;
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chkClave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClave.Checked == false)
            {
                txtClave.PasswordChar = '*';
            }
            else
            {
                txtClave.PasswordChar = '\0';
            }

        }
    }
}
