using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class UsuarioLogic:BusinessLogic
    {
        private Data.Database.UsuarioAdapter _UsuarioData;
        public Data.Database.UsuarioAdapter UsuarioData
        {
            get { return _UsuarioData; }
            set { _UsuarioData = value; }
        }
        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();  
        }
        
        public Business.Entities.Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id); 
        }

        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }


        public void Save(Business.Entities.Usuario user)
        {
            UsuarioData.Save(user); 
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }
    }
}
