using System;
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
            get => default;
            set
            {
            }
        }

        public int IDAlumno
        {
            get => default;
            set
            {
            }
        }

        public int IDCurso
        {
            get => default;
            set
            {
            }
        }

        public int Nota
        {
            get => default;
            set
            {
            }
        }
    }
}