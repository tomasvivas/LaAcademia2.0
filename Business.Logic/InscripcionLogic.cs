using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class InscripcionLogic
    {
        public List<AlumnoInscripcion> GetAll(int id)
        {
            InscripcionAdapter ia = new InscripcionAdapter();
            return ia.GetAll(id);
        }

        public AlumnoInscripcion GetOne(int id)
        {
            InscripcionAdapter ia = new InscripcionAdapter();
            return ia.GetOne(id);
        }

        public List<Curso> GetCursosAlumno(int id)
        {
            InscripcionAdapter ia = new InscripcionAdapter();
            return ia.GetCursosAlumno(id);
        }

        public void Save(AlumnoInscripcion ins)
        {
            InscripcionAdapter ia = new InscripcionAdapter();
            ia.Save(ins);
        }
    }
}
