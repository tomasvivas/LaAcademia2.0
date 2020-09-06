using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic:BusinessLogic 
    {
        private Data.Database.PlanAdapter _PlanData;
        public Data.Database.PlanAdapter PlanData
        {
            get { return _PlanData; }
            set { _PlanData = value; }
        }
        public PlanLogic()
        {
            PlanData = new PlanAdapter(); 
        }
        public Business.Entities.Plan GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        public List<Especialidad> GetEspecialidad()
        {
            return PlanData.GetEspecialidad();
        }

        public void Save(Plan plan)
        {
            PlanData.Save(plan);
        }

        public void Delete(int id)
        {
            PlanData.Delete(id);
        }
    }
}
