using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class DocenteCursoLogic: BusinessLogic
    {
        private Data.Database.DocenteCursoAdapter _DocenteCursoData;
        public Data.Database.DocenteCursoAdapter DocenteCursoData
        {
            get { return _DocenteCursoData; }
            set { _DocenteCursoData = value; }
        }

        public DocenteCursoLogic()
        {
            DocenteCursoData = new DocenteCursoAdapter(); 
        }


        public DocenteCurso GetOne(int id)
        {
            return DocenteCursoData.GetOne(id);  
        }

        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoData.GetAll();
        }

        public List<Curso> GetCursos()
        {
            return DocenteCursoData.GetCursos();
        }

        public void Save(Business.Entities.DocenteCurso dc)
        {
            DocenteCursoData.Save(dc);
        }

        public void Delete(int id)
        {
            DocenteCursoData.Delete(id);
        }
    }
}
