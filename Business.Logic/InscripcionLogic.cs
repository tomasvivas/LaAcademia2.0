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
        public InscripcionLogic()
        {
            cursoAdapter = new CursoAdapter();
            ins = new InscripcionAdapter();
        }

        private CursoAdapter _cursoAdapter;
        public CursoAdapter cursoAdapter
        {
            get { return _cursoAdapter; }
            set { _cursoAdapter = value; }
        }

        private InscripcionAdapter _ins;
        public InscripcionAdapter ins
        {
            get { return _ins; }
            set { _ins = value; }
        }

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

        public List<Curso> GetCursosAlumno(Persona p)
        {
            List<Curso> cursos = new List<Curso>();
            List<Curso> disp = new List<Curso>();
            List<AlumnoInscripcion> inscripciones = new List<AlumnoInscripcion>();
            InscripcionAdapter ins = new InscripcionAdapter();
            inscripciones = ins.GetInscripciones(p.ID);
            cursos = cursoAdapter.GetAll();
            disp = (from Curso in cursos where (Curso.AnioCalendario == DateTime.Now.Year && Curso.Cupo > 0 && inscripciones.All(p2 => p2.IDCurso != Curso.ID)) select Curso).ToList();
            return disp;

        }

        public void Save(AlumnoInscripcion ins)
        {
            InscripcionAdapter ia = new InscripcionAdapter();
            ia.Save(ins);
        }
    }
}
