public class Temporadas
{
    public int IdTemporada{get;set;}
    public int IdSerie{get;set;}
    public int NumeroTemporada{get;set;}
    public string TituloTemporadas{get;set;}

    public Temporadas()
    {

    }
    public Temporadas(int idTemp, int IdSer, int NumTemp, string TitleTemp)
    {
        IdTemporada = idTemp;
        IdSerie = IdSer;
        NumeroTemporada = NumTemp;
        TituloTemporadas = TitleTemp;
    }
}