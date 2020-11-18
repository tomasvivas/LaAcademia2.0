using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Form.Dispose();
            Menu menu = new Menu();
            menu.Show();  
        }

        private Form _form;

        public Form Form  
        {get { return _form; }
         set { _form = value; }
        }

    }
}
