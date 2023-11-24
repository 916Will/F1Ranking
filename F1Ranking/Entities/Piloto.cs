namespace F1Ranking.Entities;

internal class Piloto
{
    public string Nome { get; set; }
    public int Pontos { get; set; }
    public int NumeroDoCarro { get; set; }

    public Piloto() { }

    public Piloto(string nome, int numeroDoCarro, int pontosDoPiloto)
    {
        Nome = nome;
        NumeroDoCarro = numeroDoCarro;
        Pontos = pontosDoPiloto;
    }

}
