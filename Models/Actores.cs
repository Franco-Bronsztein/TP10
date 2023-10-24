public class Actores
{
    public int IdActor{get;set;}
    public int IdSerie{get;set;}
    public string Nombre{get;set;}

    public Actores()
    {
        
    }
    public Actores(int IdAct, int IDSer, string nom)
    {
       IdActor = IdAct;
       IdSerie = IDSer;
       Nombre = nom;
    }
}