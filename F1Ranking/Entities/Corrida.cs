namespace F1Ranking.Entities;

public class Corrida
{
    public int NomeDaCorrida { get; set; }
    public DateTime Data { get; set; }
    
    public Corrida() { }
    public Corrida(int nomeDaCorrida, DateTime data)
    {
        NomeDaCorrida = nomeDaCorrida;
        Data = data;
    }
}
    