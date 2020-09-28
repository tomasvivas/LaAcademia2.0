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
    public class MateriaAdapter:Adapter
    {

        public MateriaAdapter()
        {


        }

        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT materias.id_materia, materias.desc_materia, materias.hs_semanales, " +
                    "materias.hs_totales, materias.id_plan, planes.desc_plan FROM materias " +
                    "INNER JOIN planes ON planes.id_plan = materias.id_plan ", sqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                while (drMaterias.Read())
                {
                    Materia mate = new Materia();
                    mate.ID = (int)drMaterias["id_materia"];
                    mate.Descripcion = (string)drMaterias["desc_materia"];
                    mate.HSSemanales = (int)drMaterias["hs_semanales"];
                    mate.HSTotales = (int)drMaterias["hs_totales"];
                    mate.IDPlan = (int)drMaterias["id_plan"];
                    mate.descPlan = (string)drMaterias["desc_plan"];

                    materias.Add(mate);
                }
                drMaterias.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de materias", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return materias;
        }

        public Materia GetOne(int ID)
        {
            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT materias.id_materia, materias.desc_materia, materias.hs_semanales, " +
                    "materias.hs_totales, materias.id_plan, planes.desc_plan FROM materias " +
                    "INNER JOIN planes ON planes.id_plan = materias.id_plan where materias.id_materia = @id; ", sqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                while (drMaterias.Read())
                {
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.HSSemanales = (int)drMaterias["hs_semanales"];
                    mat.HSTotales = (int)drMaterias["hs_totales"];
                    mat.IDPlan = (int)drMaterias["id_plan"];
                    mat.descPlan = (string)drMaterias["desc_plan"];
                }
                drMaterias.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mat;
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

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE materias SET desc_materia = @desc_materia, hs_semanales = @HSSemanales,hs_temanales = @HSTotales, id_plan = @idPlan, " +
                    "WHERE id_materia = @id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = mat.ID;
                cmdSave.Parameters.Add("@HSSemanales", SqlDbType.Int).Value = mat.HSSemanales;
                cmdSave.Parameters.Add("@HSTotales", SqlDbType.Int).Value = mat.HSTotales;
                cmdSave.Parameters.Add("@idPlan", SqlDbType.Int).Value = mat.IDPlan;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into materias(desc_materia,hs_semanales,hs_totales,id_plan) " +
                    "values (@desc_materia,@HSSemanales,@HSTotales,@idPlan) " +
                    "select @@identity", sqlConn);
                cmdSave.Parameters.Add("@HSSemanales", SqlDbType.Int).Value = mat.HSSemanales;
                cmdSave.Parameters.Add("@HSTotales", SqlDbType.Int).Value = mat.HSTotales;
                cmdSave.Parameters.Add("@idPlan", SqlDbType.Int).Value = mat.IDPlan;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                mat.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia mat)
        {
            if (mat.State == BusinessEntity.States.New)
            {
                this.Insert(mat);
            }
            else if (mat.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mat.ID);
            }
            else if (mat.State == BusinessEntity.States.Modified)
            {
                this.Update(mat);
            }
            mat.State = BusinessEntity.States.Unmodified;
        }
    }
}
