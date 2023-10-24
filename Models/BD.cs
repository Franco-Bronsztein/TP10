using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;


public class BD
{
    private static string _connectionString = @"Server=localHost;DataBase=BDSeries;Trusted_Connection=True;";
    static List<Temporadas> _ListadoTemporadas = new List<Temporadas>();
    static List<Actores> _ListadoActores = new List<Actores>();
    static Series _UnaSerie = new Series();

     public static List<Temporadas> ObtenerTemporadas(int IdSerie)
    {
        
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Temporadas where IdSerie = @IdSP";
            _ListadoTemporadas = db.Query<Temporadas>(sql, new {IdSP = IdSerie}).ToList();
        }
        return _ListadoTemporadas;
    }
    public static List<Actores> ObtenerActores(int IdSerie)
    {
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Actores where IdSerie = @IdSP";
            _ListadoActores = db.Query<Actores>(sql, new {IdSP = IdSerie}).ToList();
        }
        return _ListadoActores;
    }
    public static Series obtenerSeries(int IdSerie)
    {

        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Series where IdSerie = @IdSP";
            _UnaSerie = db.QueryFirstOrDefault<Series>(sql,  new {IdSP = IdSerie});
        }
        return _UnaSerie;
    }

    public static List<Series> ObtenerSeriesFull()
    {
        List<Series> _ObtenerSeries = new List<Series>();
        using(SqlConnection db = new SqlConnection(_connectionString) ){
            string SQL = "SELECT * FROM Series";
            _ObtenerSeries =  db.Query<Series>(SQL).ToList();
        }
        return _ObtenerSeries;
    }
}

