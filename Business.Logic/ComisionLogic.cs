using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        private Data.Database.ComisionAdapter _ComisionData;
        public Data.Database.ComisionAdapter ComisionData
        {
            get { return _ComisionData; }
            set { _ComisionData = value; }
        }

        public ComisionLogic()
        {
            ComisionData = new ComisionAdapter();
        }

        public Business.Entities.Comision GetOne(string descripcion)
        {
            return ComisionData.GetOne(descripcion);
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public void Save(Business.Entities.Comision comision)
        {
            ComisionData.Save(comision);
        }

        public void Delete(string descripcion)
        {
            ComisionData.Delete(descripcion);
        }
    }
}
