using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Adapter
    {
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");

        protected void OpenConnection()
        {
            throw new Exception("Metodo no implementado");
            /* paso 11 del TP2LAB05 
             11.En el método OpenConnection guardaremos el valor del connectionstring
             en una variable invocando a
             ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString */ 
           
        }

        protected void CloseConnection()
        {
            throw new Exception("Metodo no implementado");
            sqlConn.Close(); 
            sqlConn=null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
