// Crear una clase en Models para conectarse a la base de datos y clases para leer los datos de cada tabla.
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;


    public class BD
    {
        private static string _connectionString = @"Server=localhost;Database=.;Trusted_Connection=True;";

       public List<Serie> ObtenerSeries()
        {
            List<Serie> series;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Series";
                series = db.Query<Serie>(sql).AsList();
            }
            return series;
        }

        public List<Actor> ObtenerActoresPorSerie(int serieId)
        {
            List<Actor> actores;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Actores WHERE IdSerie = @SerieId";
                actores = db.Query<Actor>(sql, new { SerieId = serieId }).AsList();
            }
            return actores;
        }

        public List<Temporada> ObtenerTemporadasPorSerie(int serieId)
        {
            List<Temporada> temporadas;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Temporadas WHERE IdSerie = @SerieId";
                temporadas = db.Query<Temporada>(sql, new { SerieId = serieId }).AsList();
            }
            return temporadas;
        }
    }
    
