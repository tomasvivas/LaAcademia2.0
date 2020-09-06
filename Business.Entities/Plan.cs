using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private string _Descripcion;
        private int _IDEspecialidad;
        public string _DescEspecialidad;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int IDEspecialidad
        {
            get { return _IDEspecialidad; }
            set { _IDEspecialidad = value; }
        }

        

        public string DescEspecialidad
        {
            get { return _DescEspecialidad; }
            set { _DescEspecialidad = value; }
        }
    }
}