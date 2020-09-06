﻿using Business.Entities;
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
            UsuarioLogic user = new UsuarioLogic();
            Usuario usuarioActual = new Usuario();
            usuarioActual = user.GetOne(txtUsuario.Text); 

            if (usuarioActual is null || (usuarioActual.Clave != txtClave.Text))
            {
                this.Notificar("Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
