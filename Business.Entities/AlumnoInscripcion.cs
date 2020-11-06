using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private string _Condicion, _DescMateria, _DescComision;
        private int _IDAlumno;
        private int _IDCurso;
        private int _Nota;

        public string Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }

        public string DescMateria
        {
            get { return _DescMateria; }
            set { _DescMateria = value; }
        }

        public string DescComision
        {
            get { return _DescComision; }
            set { _DescComision = value; }
        }

        public int IDAlumno
        {
            get { return _IDAlumno; }
            set { _IDAlumno = value; }
        }

        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value;  }
        }
    }
}