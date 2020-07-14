using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        private static List<Especialidad> _Especialidad;

        private static List<Especialidad> Especialidades
        {
            get
            {
                if (_Especialidad == null)
                {
                    _Especialidad = new List<Business.Entities.Especialidad>();
                    Business.Entities.Especialidad esp;
                    esp = new Business.Entities.Especialidad();
                    esp.State = Business.Entities.BusinessEntity.States.Unmodified;
                    esp.Descripcion = "Ing. Quimica";
                    _Especialidad.Add(esp);

                }
                return _Especialidad;
            }

        }

        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidad = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select * from especialidades", sqlConn);
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                while (drEspecialidad.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.Descripcion = (string)drEspecialidad["descripcion"];
                    especialidad.Add(esp);




                }
                drEspecialidad.Close();
            }

            catch (Exception Ex)
            {


                Exception ExcepcionManejada = new Exception("Error al recuperar lista de especialidades", Ex);
                throw ExcepcionManejada;


            }

            finally
            {
                this.CloseConnection();
            }
            return especialidad;
        }

        public Business.Entities.Especialidad GetOne(string Descripcion)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select * from especialidades where descripcion=@descripcion", sqlConn);
                cmdEspecialidad.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = Descripcion;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                if (drEspecialidad.Read())
                {
                    esp.Descripcion = (string)drEspecialidad["descripcion"];
                }

                drEspecialidad.Close();
            }

            catch (Exception Ex)

            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de especialidad", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
            return esp;

        }

        public void Delete(string descripcion)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete especialidades where descripcion=@descripcion", sqlConn);
                cmdDelete.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = descripcion;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.Descripcion);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}


