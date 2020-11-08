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

        public List<AlumnoInscripcion> GetInscripciones(int ID)
        {
            List<AlumnoInscripcion> inscripciones = new List<AlumnoInscripcion>();
            this.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT id_inscripcion, id_alumno, alumnos_inscripciones.id_curso, condicion " +
                "FROM alumnos_inscripciones INNER JOIN cursos ON cursos.id_curso = alumnos_inscripciones.id_curso WHERE id_alumno = @id", sqlConn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            SqlDataReader drIns = cmd.ExecuteReader();
            while (drIns.Read())
            {
                AlumnoInscripcion aluIns = new AlumnoInscripcion();
                aluIns.ID = (int)drIns["id_inscripcion"];
                aluIns.IDCurso = (int)drIns["id_curso"];
                aluIns.IDAlumno = (int)drIns["id_alumno"];

                inscripciones.Add(aluIns);
            }
            drIns.Close();
            CloseConnection();
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

        public void Insert(AlumnoInscripcion ins)
        {
            this.OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO alumnos_inscripciones(id_alumno, id_curso, condicion) values (@id_alumno," +
                "@id_curso, @condicion); UPDATE cursos SET cupo = cupo-1 WHERE id_curso = @id_curso", sqlConn);
            cmd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ins.IDAlumno;
            cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = ins.IDCurso;
            cmd.Parameters.Add("@condicion", SqlDbType.VarChar).Value = ins.Condicion;
            cmd.ExecuteNonQuery();
            this.CloseConnection();
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
