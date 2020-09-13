using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    class ComisionLogic : BusinessLogic
    {
        private Data.Database.ComisionAdapter _ComData;
        public Data.Database.ComisionAdapter ComisionData
        {
            get { return _ComData; }
            set { _ComData = value; }
        }
        public ComisionLogic()
        {
            ComisionData = new ComisionAdapter();
        }
        public Business.Entities.Comision GetOne(int id)
        {
            return ComisionData.GetOne(id);
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public List<Plan> GetPlan()
        {
            return ComisionData.GetPlanes();
        }

        public void Save(Comision com)
        {
            ComisionData.Save(com);
        }

        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }

    }
}
