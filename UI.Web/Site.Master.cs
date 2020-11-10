using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            PersonaLogic pl = new PersonaLogic();
            Pers = pl.GetOne(log.idalum);
            
        }

        private Persona _pers;
        public Persona Pers
        {
            get { return _pers; }
            set { _pers = value; }
        }
    }
}