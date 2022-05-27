using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace TP10.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=A-CBO-06; DataBase=BDPadron; Trusted_Connection=True";
        private static List<Establecimiento> _ListaEstablecimiento = new List<Establecimiento>();
        private static List<Persona> _EXP = new List<Persona>();

        public static Persona ConsultaPadron(int DNI){
            Persona MiPersona = null;
            string sql = "SELECT * from Personas WHERE DNI = @pDNI";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                MiPersona = db.QueryFirstOrDefault<Persona>(sql, new{ pDNI = DNI});
            }
            return MiPersona;
        }
        public static Establecimiento ConsultaEstablecimiento(int IdEstablecimiento){
            Establecimiento MiEstablecimiento = null;
            string sql = "SELECT * from Establecimiento WHERE IdEstablecimiento = @pIdEstablecimiento";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                MiEstablecimiento = db.QueryFirstOrDefault<Establecimiento>(sql, new{ pIdEstablecimiento = IdEstablecimiento});
            }
            return MiEstablecimiento;
        }

        public static bool Votar(int DNI, int NumeroTramite){
            bool pudoVotar = false;
            int ahya = 0;
            string sql = "UPDATE Personas SET Voto = 1, FechaVoto = @pFecha WHERE DNI=@pDNI and NumeroTramite=@pNumeroTramite";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                ahya = db.Execute(sql, new{ pDNI = DNI, pNumeroTramite=NumeroTramite, pFecha = DateTime.Today});
            }
            if(ahya==1){
                pudoVotar=true;
            }
            return pudoVotar;
        }

        public static List<Persona> EXP(int IdEstablecimiento){
            string sql = "SELECT * FROM Personas WHERE IdEstablecimiento=@pId ORDER BY Apellido";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                _EXP = db.Query<Persona>(sql, new{ pId = IdEstablecimiento}).ToList();
            }
            return _EXP;
        }

        public static List<Establecimiento> Mostrar(){
            string sql = "SELECT * FROM Establecimiento ORDER BY Nombre";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                _ListaEstablecimiento = db.Query<Establecimiento>(sql).ToList();
            }
            return _ListaEstablecimiento;
        }
    }
}