using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic
    {
        private CursoAdapter _CursoData;
        public CursoAdapter CursoData
        {
            get { return _CursoData; }
            set { _CursoData = value; }
        }

        public CursoLogic()
        {
            CursoData = new CursoAdapter(); 
        }


        public Curso GetOne(int id)
        {
            return CursoData.GetOne(id);  
        }

        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }

        public List<Materia> GetMaterias()
        {
            return CursoData.GetMaterias();
        }

        public List<Comision> GetComisiones()
        {
            return CursoData.GetComisiones();
        }

        public void Save(Business.Entities.Curso cur)
        {
            CursoData.Save(cur);
        }

        public void Delete(int id)
        {
            CursoData.Delete(id);
        }
    }
}
