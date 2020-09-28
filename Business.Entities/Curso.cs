using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AnioCalendario;
        private int _Cupo;
        private int _IDComision;
        private int _IDMateria;
        private string _DescComision;
        private string _DescMateria;

        public int AnioCalendario
        {
            get { return _AnioCalendario; }
            set { _AnioCalendario = value; }
        }

        public int Cupo
        {
            get { return _Cupo; }
            set { _Cupo = value; }
        }


        public int IDComision
        {
            get { return _IDComision; }
            set { _IDComision = value; }
        }

        public int IDMateria
        {
            get { return _IDMateria; }
            set { _IDMateria = value; }
        }

        public string DescComision
        {
            get { return _DescComision; }
            set { _DescComision = value; }
        }

        public string DescMateria
        {
            get { return _DescMateria; }
            set { _DescMateria = value;  }
        }
    }
}