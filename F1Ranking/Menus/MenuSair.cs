using F1Ranking.Entities;

namespace F1Ranking.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Campeonato> campeonato)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
