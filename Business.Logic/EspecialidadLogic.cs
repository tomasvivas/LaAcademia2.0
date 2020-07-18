using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        private Data.Database.EspecialidadAdapter _EspecialidadData;
        public Data.Database.EspecialidadAdapter EspecialidadData
        {
            get { return _EspecialidadData; }
            set { _EspecialidadData = value; }
        }
        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
        }

        public Business.Entities.Especialidad GetOne(string descripcion)
        {
            return EspecialidadData.GetOne(descripcion);
        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }


        public void Save(Business.Entities.Especialidad especialidad)
        {
            EspecialidadData.Save(especialidad);
        }

        public void Delete(string descripcion)
        {
            EspecialidadData.Delete(descripcion);
        }
    }
}