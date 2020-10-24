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
    public class DocenteCursoAdapter: Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> docentescursos = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocentesCursos = new SqlCommand("SELECT dc.id_curso, dc.id_docente, dc.cargo, " +
                    "FROM docentes_cursos dc " +
                    "INNER JOIN cursos cur on dc.id_curso = cur.id_curso"
                     , sqlConn);
                SqlDataReader drDocentesCursos = cmdDocentesCursos.ExecuteReader();
                while (drDocentesCursos.Read())
                {
                    DocenteCurso dc = new DocenteCurso();
                    dc.IDCurso = (int)drDocentesCursos["id_curso"];
                    dc.IDDocente = (int)drDocentesCursos["id_docente"];
                    dc.Cargo = (Business.Entities.DocenteCurso.TiposCargos)drDocentesCursos["Cargo"];

                    docentescursos.Add(dc);
                }
                drDocentesCursos.Close();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de Docentes_cursos", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docentescursos;
        }

        public DocenteCurso GetOne(int ID)
        {
            DocenteCurso dc = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCursos = new SqlCommand("SELECT dc.id_curso, dc.id_docente, dc.cargo, " +
                    "FROM docentes_cursos dc " +
                    "INNER JOIN cursos cur on dc.id_curso = cur.id_curso" +
                    "WHERE dc.id_docente = @id", sqlConn);
                cmdDocenteCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDocenteCursos = cmdDocenteCursos.ExecuteReader();
                while (drDocenteCursos.Read())
                {
                    dc.IDCurso = (int)drDocenteCursos["id_curso"];
                    dc.IDDocente = (int)drDocenteCursos["id_docente"];
                    dc.Cargo = (Business.Entities.DocenteCurso.TiposCargos)drDocenteCursos["Cargo"];
                }
                drDocenteCursos.Close();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Docente_curso", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return dc;
        }

        public List<Curso> GetCursos()
        {
            List<Curso> cursos = new List<Curso>();
            this.OpenConnection();
            SqlCommand cmdCursos = new SqlCommand("SELECT cur.id_curso, cur.desc_comision, cur.cupo, cur.desc_materia, cur.anio_calendario" +
            "FROM cursos cur", sqlConn);
            SqlDataReader drCursos = cmdCursos.ExecuteReader();

            while (drCursos.Read())
            {
                Curso cur = new Curso();
                cur.ID = (int)drCursos["id_curso"];
                cur.DescMateria = (string)drCursos["id_comision"];
                cur.DescComision = (string) drCursos ["desc_comision"];
                cur.Cupo = (int) drCursos ["cupo"];
                cur.AnioCalendario = (int) drCursos ["anio_calendario"];
                cursos.Add(cur);
            }

            return cursos;
        }

         public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete docente_curso where id_docente=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar Docente_curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

         protected void Update(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE docente_curso SET cargo = @Cargo, id_curso = @IDcurso " +
                    "WHERE id_docente= @id", sqlConn);
                cmdSave.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = dc.Cargo;
                cmdSave.Parameters.Add("@IDcurso", SqlDbType.Int).Value = dc.IDCurso;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del Docente_curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO docente_curso(id_docente, id_curso, cargo) " +
                    "values (@Cupo,@AnioCalendario,@IDMateria,@IDComision) " +
                    "select @@identity", sqlConn);
                cmdSave.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = dc.Cargo;
                cmdSave.Parameters.Add("@IDcurso", SqlDbType.Int).Value = dc.IDCurso;
                dc.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear docente_curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(DocenteCurso dc)
        {
            if (dc.State == BusinessEntity.States.New)
            {
                this.Insert(dc);
            }
            else if (dc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(dc.ID);
            }
            else if (dc.State == BusinessEntity.States.Modified)
            {
                this.Update(dc);
            }
            dc.State = BusinessEntity.States.Unmodified;
        }


    }
}
