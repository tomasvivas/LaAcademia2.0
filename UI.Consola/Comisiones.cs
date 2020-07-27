using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Consola
{
    public class Comisiones
    {
        private Business.Logic.ComisionLogic _ComisionNegocio;

        public Business.Logic.ComisionLogic ComisionNegocio
        {
            get { return _ComisionNegocio; }
            set { _ComisionNegocio = value; }
        }

        public Comisiones(Business.Logic.ComisionLogic comision)
        {
            ComisionNegocio = comision;

        }
    }
}
