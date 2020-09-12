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
    public class PersonaAdapter:Adapter
    {

        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT personas.id_persona, personas.nombre, personas.apellido, personas.direccion, " +
                    "personas.email, personas.telefono, personas.fecha_nac, personas.legajo, " +
                    "personas.tipo_persona, planes.id_plan, planes.desc_plan FROM personas " +
                    "INNER JOIN planes ON planes.id_plan = personas.id_plan ", sqlConn);            
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Persona per = new Persona();
                    per.ID = (int)drPersonas["id_persona"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (Persona.TipoPersonas)drPersonas["tipo_persona"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    per.DescPlan = (string)drPersonas["desc_plan"];
                    personas.Add(per);

                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de personas", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }

        public Persona GetOne(int id)
        {
            Persona per = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT personas.id_persona, personas.nombre, personas.apellido, personas.direccion, " +
                       "personas.email, personas.telefono, personas.fecha_nac, personas.legajo, " +
                       "personas.tipo_persona, planes.id_plan, planes.desc_plan FROM personas " +
                       "INNER JOIN planes ON planes.id_plan = personas.id_plan " +
                       "WHERE id_persona = @id", sqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (Persona.TipoPersonas)drPersonas["tipo_persona"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    per.DescPlan = (string)drPersonas["desc_plan"];
                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;

        }

        public List<Plan> GetPlanes()
        {
            List<Plan> planes = new List<Plan>();
            this.OpenConnection();
            SqlCommand cmdPlanes = new SqlCommand("SELECT id_plan, desc_plan FROM planes", sqlConn);
            SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

            while (drPlanes.Read())
            {
                Plan pl = new Plan();
                pl.ID = (int)drPlanes["id_plan"];
                pl.Descripcion = (string)drPlanes["desc_plan"];
                planes.Add(pl);
            }

            return planes;
        }

        protected void Update(Persona per)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE personas SET nombre = @nombre, " +
                    "apellido = @apellido, direccion = @direccion, email = @email, telefono = @telefono, fecha_nac = @fecha_nac, " +
                    "legajo = @legajo, tipo_persona = @tipo_persona, id_plan = @id_plan  WHERE id_persona = @id", sqlConn);
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = per.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = per.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = per.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = per.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = per.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = per.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = per.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = per.TipoPersona;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = per.ID;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = per.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Persona per)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "insert into personas(nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) " +
                    "values(@nombre, @apellido, @direccion, @email, @telefono, @fecha_nac, @legajo, @tipo_persona, @id_plan)" +
                    "select @@identity", sqlConn);
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = per.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = per.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = per.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = per.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = per.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = per.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = per.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = per.TipoPersona;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = per.ID;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = per.IDPlan;
                per.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la persona", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Persona per)
        {
            if (per.State == BusinessEntity.States.New)
            {
                this.Insert(per);
            }
            else if (per.State == BusinessEntity.States.Deleted)
            {
                this.Delete(per.ID);
            }
            else if (per.State == BusinessEntity.States.Modified)
            {
                this.Update(per);
            }
            per.State = BusinessEntity.States.Unmodified;
        }
    }
}
