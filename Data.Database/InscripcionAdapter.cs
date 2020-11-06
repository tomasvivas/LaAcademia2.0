using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database
{
    public class InscripcionAdapter : Adapter 
    {
        public List<AlumnoInscripcion> GetAll(int IDalum)
        {
            List<AlumnoInscripcion> inscripciones = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("SELECT ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, ai.nota, " +
                    "comisiones.desc_comision, materias.desc_materia " +
                    "FROM alumnos_inscripciones ai " +
                    "INNER JOIN personas on personas.id_persona = ai.id_alumno " +
                    "INNER JOIN cursos on cursos.id_curso = ai.id_curso" +
                    "INNER JOIN comisiones on comisiones.id_comision = curso.id_comision" +
                    "INNER JOIN materias on materias.id_materia = curso.id_materia" +
                    "WHERE ai.id_alumno = @id" , sqlConn);
                cmdInscripciones.Parameters.Add("@id", SqlDbType.Int).Value = IDalum;
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();
                while (drInscripciones.Read())
                {
                    AlumnoInscripcion ins = new AlumnoInscripcion();
                    ins.ID = (int)drInscripciones["id_inscripcion"];
                    ins.IDAlumno = (int)drInscripciones["id_alumno"];
                    ins.IDCurso = (int)drInscripciones["id_curso"];
                    ins.Condicion = (string)drInscripciones["condicion"];
                    ins.Nota = (int)drInscripciones["nota"];
                    ins.DescComision = (string)drInscripciones["desc_comision"];
                    ins.DescMateria = (string)drInscripciones["desc_materia"];
                    inscripciones.Add(ins);
                }
                drInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de las inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return inscripciones;
        }

        public AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion ins = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("SELECT ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, ai.nota, " +
                    "comisiones.desc_comision, materias.desc_materia " +
                    "FROM alumnos_inscripciones ai " +
                    "INNER JOIN personas on personas.id_persona = ai.id_alumno " +
                    "INNER JOIN cursos on cursos.id_curso = ai.id_curso" +
                    "INNER JOIN comisiones on comisiones.id_comision = curso.id_comision" +
                    "INNER JOIN materias on materias.id_materia = curso.id_materia" +
                    "WHERE ai.id_inscripcion = @id", sqlConn);
                cmdInscripciones.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();
                while (drInscripciones.Read())
                {
                    ins.ID = (int)drInscripciones["id_inscripcion"];
                    ins.IDAlumno = (int)drInscripciones["id_alumno"];
                    ins.IDCurso = (int)drInscripciones["id_curso"];
                    ins.Condicion = (string)drInscripciones["condicion"];
                    ins.Nota = (int)drInscripciones["nota"];
                    ins.DescComision = (string)drInscripciones["desc_comision"];
                    ins.DescMateria = (string)drInscripciones["desc_materia"];
                }
                drInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return ins;
        }

        public List<Curso> GetCursosAlumno(int IDalum)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT cur.id_curso, cur.id_materia, cur.id_comision, " +
                    "cur.anio_calendario, cur.cupo, materias.desc_materia, comisiones.desc_comision FROM cursos cur " +
                    "INNER JOIN materias ON materias.id_materia = cur.id_materia " +
                    "INNER JOIN comisiones ON comisiones.id_comision = cur.id_comision " +
                    "LEFT JOIN alumnos_inscripciones on alumnos_inscripciones.id_curso = cur.id_curso " +
                    "WHERE alumnos_inscripciones.id_alumno != @id", sqlConn);
                cmdCursos.Parameters.Add("@id", SqlDbType.Int).Value = IDalum;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso cur = new Curso();
                    cur.ID = (int)drCursos["id_curso"];
                    cur.Cupo = (int)drCursos["cupo"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.IDComision = (int)drCursos["id_comision"];
                    cur.DescComision = (string)drCursos["desc_comision"];
                    cur.DescMateria = (string)drCursos["desc_materia"];

                    cursos.Add(cur);
                }
                drCursos.Close();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de cursos", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        protected void Insert(AlumnoInscripcion ai)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO alumnos_inscripcion(id_alumno, id_curso, condicion, nota) " +
                    "values (@id_alumno,@id_curso,@condicion,@nota) " +
                    "select @@identity", sqlConn);
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ai.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = ai.IDCurso;
                cmdSave.Parameters.Add("@condicon", SqlDbType.VarChar,20).Value = ai.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = ai.Nota;
                ai.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(AlumnoInscripcion ai)
        {
            if (ai.State == BusinessEntity.States.New)
            {
                this.Insert(ai);
            }
            else if (ai.State == BusinessEntity.States.Deleted)
            {
               // this.Delete(cur.ID);
            }
            else if (ai.State == BusinessEntity.States.Modified)
            {
               // this.Update(cur);
            }
            ai.State = BusinessEntity.States.Unmodified;
        }
    }
}
