using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace TP11.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=SANTISIELE\SQLEXPRESS; DataBase=BDWebCursos; Trusted_Connection=True";
        private static List<Curso> _ListaCursos = new List<Curso>();
        private static List<Especialidad> _ListaEspecialidades = new List<Especialidad>();
        public static Curso ConsultaCurso(int IdCurso){
            Curso MiCurso = null;
            string sql = "SELECT * from Cursos WHERE IdCurso = @pIdCurso";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                MiCurso = db.QueryFirstOrDefault<Curso>(sql, new{ pIdCurso = IdCurso});
            }
            return MiCurso;
        }
        public static Especialidad ConsultaEspecialidad(int IdEspecialidad){
            Especialidad MiEspecialidad = null;
            string sql = "SELECT * from Especialidades WHERE IdEspecialidad = @pIdEspecialidad";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                MiEspecialidad = db.QueryFirstOrDefault<Especialidad>(sql, new{ pIdEspecialidad = IdEspecialidad});
            }
            return MiEspecialidad;
        }
        public static List<Curso> ListarCursos(int IdEspecialidad){
            string sql="";
            if(IdEspecialidad==-1){
                sql = "SELECT * from Cursos";
            }else{
                sql = "SELECT * from Cursos WHERE IdEspecialidad = @pIdEspecialidad";
            }

            using(SqlConnection db = new SqlConnection(_connectionString)){
                _ListaCursos = db.Query<Curso>(sql, new{ pIdEspecialidad = IdEspecialidad}).ToList();
            }
            return _ListaCursos;
        }

        public static void AgregarCurso(Curso MiCurso){
            string sql = "INSERT INTO Cursos(Nombre,Descripcion,Imagen,UrlCurso,MeGusta,NoMeGusta,IdEspecialidad) VALUES(@pNombre, @pDescripcion, @pImagen, @pUrlCurso, 0, 0, @pIdEspecialidad)";
            int temp=0;
            using(SqlConnection db = new SqlConnection(_connectionString)){
                temp = db.Execute(sql, new{ pNombre = MiCurso.Nombre, pDescripcion=MiCurso.Descripcion, pImagen = MiCurso.Imagen, pUrlCurso=MiCurso.UrlCurso, pIdEspecialidad=MiCurso.IdEspecialidad});
            }
        }

        public static void CalificarCurso(int IdCurso, bool Like){
            string sql = "";
            int temp = 0;
            if(Like){
                sql = "UPDATE Cursos SET MeGusta = MeGusta + 1 WHERE IdCurso = @pIdCurso";
            }else{
                sql = "UPDATE Cursos SET NoMeGusta = NoMeGusta + 1 WHERE IdCurso = @pIdCurso";
            }
            using(SqlConnection db = new SqlConnection(_connectionString)){
                temp = db.Execute(sql, new{pIdCurso=IdCurso});
            }
        }
        public static List<Especialidad> ListaEspecialidades(){
            string sql = "SELECT * from Especialidades";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                _ListaEspecialidades = db.Query<Especialidad>(sql).ToList();
            }
            return _ListaEspecialidades;
        }
    }
}