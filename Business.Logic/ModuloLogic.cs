using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;


namespace Business.Logic
{
    public class ModuloLogic: BusinessLogic
    {
        private Data.Database.ModuloAdapter _ModuloData;
        public Data.Database.ModuloAdapter ModuloData 
        {
            get { return _ModuloData; }
            set { _ModuloData = value; }
        }

        public ModuloLogic()
        {
            ModuloData = new ModuloAdapter();
        }

        public Business.Entities.Modulo GetOne(string deesc)
        {
            return ModuloData.GetOne(deesc);
        }

        public List<Modulo> GetAll()
        {
            return ModuloData.GetAll();
        }

        

        public void Save(Business.Entities.Modulo modulo)
        {
            ModuloData.Save(modulo);
        }

        public void Delete(int id)
        {
            //ModuloData.Delete(id);
        }
    }
}
