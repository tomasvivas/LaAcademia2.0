using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonaLogic
    {
        private Data.Database.PersonaAdapter _PersonaData;
        public Data.Database.PersonaAdapter PersonaData
        {
            get { return _PersonaData; }
            set { _PersonaData = value; }
        }
        public PersonaLogic()
        {
            PersonaData = new PersonaAdapter();
        }

        public Business.Entities.Persona GetOne(int id)
        {
            return PersonaData.GetOne(id);
        }
        
        public List<Persona> GetAll()
        {
            return PersonaData.GetAll();
        }

        public List<Plan> GetPlanes()
        {
            return PersonaData.GetPlanes();
        }

        public void Save(Business.Entities.Persona persona)
        {
            PersonaData.Save(persona);
        }

        public void Delete(int id)
        {
            PersonaData.Delete(id);
        }

    }
}
