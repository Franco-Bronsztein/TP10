public class Series
{       
    public int IdSerie{get;set;}
    public string Nombre{get;set;}
    public int AñoInicio{get;set;}
    public string Sinopsis{get;set;}
    public string ImagenSerie{get;set;}
    public Series()
    {
        
    }
    public Series(int IdSer, string nom, int AI, string Sinop, string ImgSer)
    {
        IdSerie = IdSer;
        Nombre = nom;
        AñoInicio = AI;
        Sinopsis = Sinop;
        ImagenSerie = ImgSer;
    }
}