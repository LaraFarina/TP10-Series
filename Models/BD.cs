// Crear una clase en Models para conectarse a la base de datos y clases para leer los datos de cada tabla.
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP10Series.Models;

    public class BD
    {
        private static string _connectionString = @"Server=localhost;Database=BDSeries;Trusted_Connection=True;";

       public static List<Series> ObtenerSeries()
        {
            List<Series> series;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Series";
                series = db.Query<Series>(sql).AsList();
            }
            return series;
        }

        public static List<Actores> ObtenerActoresPorSerie(int serieId)
        {
            List<Actores> actores;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Actores WHERE IdSerie = @SerieId";
                actores = db.Query<Actores>(sql, new { SerieId = serieId }).AsList();
            }
            return actores;
        }

        public static List<Temporadas> ObtenerTemporadasPorSerie(int serieId)
        {
            List<Temporadas> temporadas;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Temporadas WHERE IdSerie = @SerieId";
                temporadas = db.Query<Temporadas>(sql, new { SerieId = serieId }).AsList();
            }
            return temporadas;
        }
public static string ObtenerSinopsisPorSerie(int serieId)
{
    string info;
    using (SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT Sinopsis FROM Series WHERE IdSerie = @SerieId";
        info = db.QueryFirstOrDefault<string>(sql, new { SerieId = serieId });
    }
    return info;
}

    }
  