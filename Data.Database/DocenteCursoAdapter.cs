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
                SqlCommand cmdDocentesCursos = new SqlCommand("SELECT dc.id_dictado, dc.id_curso, dc.id_docente, dc.cargo, " +
                    "personas.nombre, personas.apellido " +
                    "FROM docentes_cursos dc " +
                    "INNER JOIN cursos on dc.id_curso = cursos.id_curso " +
                    "INNER JOIN personas on dc.id_docente = personas.id_persona"
                     , sqlConn);
                SqlDataReader drDocentesCursos = cmdDocentesCursos.ExecuteReader();
                while (drDocentesCursos.Read())
                {
                    DocenteCurso dc = new DocenteCurso();
                    dc.ID = (int)drDocentesCursos["id_dictado"];
                    dc.IDCurso = (int)drDocentesCursos["id_curso"];
                    dc.IDDocente = (int)drDocentesCursos["id_docente"];
                    dc.Cargo = (Business.Entities.DocenteCurso.TiposCargos)drDocentesCursos["cargo"];
                    dc.Apellido = (string)drDocentesCursos["apellido"];
                    dc.Nombre = (string)drDocentesCursos["nombre"];

                    docentescursos.Add(dc);
                }
                drDocentesCursos.Close();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de Docentes cursos", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docentescursos;
        }

        public Business.Entities.DocenteCurso GetOne(int ID)
        {
            DocenteCurso dc = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCursos = new SqlCommand("SELECT dc.id_curso, dc.id_docente, dc.cargo, " +
                    "personas.nombre, personas.apellido " +
                    "FROM docentes_cursos dc " +
                    "INNER JOIN cursos on dc.id_curso = cursos.id_curso " +
                    "INNER JOIN personas on dc.id_docente = personas.id_persona " +
                    "WHERE dc.id_dictado = @id", sqlConn);
                cmdDocenteCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDocenteCursos = cmdDocenteCursos.ExecuteReader();
                while (drDocenteCursos.Read())
                {
                    dc.ID = (int)drDocenteCursos["id_dictado"];
                    dc.IDCurso = (int)drDocenteCursos["id_curso"];
                    dc.IDDocente = (int)drDocenteCursos["id_docente"];
                    dc.Cargo = (Business.Entities.DocenteCurso.TiposCargos)drDocenteCursos["cargo"];
                    dc.Apellido = (string)drDocenteCursos["apellido"];
                    dc.Nombre = (string)drDocenteCursos["nombre"];
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
            SqlCommand cmdCursos = new SqlCommand("SELECT cur.id_curso, materias.id_materia, comisiones.id_comision, comisiones.desc_comision, materias.desc_materia " +
            "FROM cursos cur " + 
            "INNER JOIN  materias on materias.id_materia = cur.id_materia " +
            "INNER JOIN comisiones on comisiones.id_comision = cur.id_comision " , sqlConn);
            SqlDataReader drCursos = cmdCursos.ExecuteReader();

            while (drCursos.Read())
            {
                Curso cur = new Curso();
                cur.ID = (int)drCursos["id_curso"];
                cur.IDComision = (int)drCursos["id_comision"];
                cur.DescComision = (string)drCursos["desc_comision"];
                cur.IDMateria = (int)drCursos["id_materia"];
                cur.DescMateria = (string)drCursos["desc_materia"];

                cursos.Add(cur);
            }

            return cursos;
        }

        public List<Persona> GetDocente()
        {
            List<Persona> docentes = new List<Persona>();
            this.OpenConnection();
            SqlCommand cmdDocentes =  new SqlCommand("SELECT id_persona, nombre, apellido FROM personas " +
                "WHERE tipo_persona = 0" , sqlConn);
            SqlDataReader drDocentes = cmdDocentes.ExecuteReader();
            while (drDocentes.Read())
            {
                Persona per = new Persona();
                per.ID = (int)drDocentes["id_persona"];
                per.Apellido = (string)drDocentes["apellido"];
                docentes.Add(per);
            }
            return docentes;
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
                SqlCommand cmdSave = new SqlCommand("UPDATE docente_curso SET id_docente = @id_docente, cargo = @cargo, id_curso = @IDcurso " +
                    "WHERE id_dictado = @id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = dc.ID;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = dc.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = dc.Cargo;
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
                    "values (@cargo,@IDCurso,@IDDocente) " +
                    "select @@identity", sqlConn);
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = dc.Cargo;
                cmdSave.Parameters.Add("@IDDocente", SqlDbType.Int).Value = dc.IDDocente;
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
