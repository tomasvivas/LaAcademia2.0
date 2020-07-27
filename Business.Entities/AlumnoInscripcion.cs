﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private int _Condicion;
        private int _IDAlumno;
        private int _IDCurso;
        private int _Nota;

        public int Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
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