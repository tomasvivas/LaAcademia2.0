using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ComisionAdapter: Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comision = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones", sqlConn);
                SqlDataReader drComision = cmdComision.ExecuteReader();
                while (drComision.Read())
                {
                    Comision com = new Comision();
                    com.Descripcion = (string)drComision["descripcion"];
                    comision.Add(com);




                }
                drComision.Close();
            }

            catch (Exception Ex)
            {


                Exception ExcepcionManejada = new Exception("Error al recuperar lista de comisiones", Ex);
                throw ExcepcionManejada;


            }

            finally
            {
                this.CloseConnection();
            }
            return comision;
        }
    }
}
