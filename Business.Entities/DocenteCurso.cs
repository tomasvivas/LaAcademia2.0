using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {   public enum TiposCargos
        {
        Auxiliar,
        Profesor
        }

        private int _IDCurso;
        private int _IDDocente;
        private TiposCargos _Cargo;

        public TiposCargos Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        public int IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }
    }
}