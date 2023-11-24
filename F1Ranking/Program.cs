using F1Ranking.Entities;
using F1Ranking.Menus;

Dictionary<string, Campeonato> campeonato = new();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuIniciarCampeonato());
opcoes.Add(2, new MenuAdicionarPiloto());
opcoes.Add(3, new MenuAlterarPiloto());
opcoes.Add(4, new MenuRemoverPiloto());
opcoes.Add(5, new MenuAdicionarCorrida());
opcoes.Add(6, new MenuAdicionarPontuacao());
opcoes.Add(-1, new MenuSair());


void ExibirLogo()
{
    Console.WriteLine(@"
    ███████╗░░███╗░░  ██████╗░░█████╗░███╗░░██╗██╗░░██╗██╗███╗░░██╗░██████╗░
    ██╔════╝░████║░░  ██╔══██╗██╔══██╗████╗░██║██║░██╔╝██║████╗░██║██╔════╝░
    █████╗░░██╔██║░░  ██████╔╝███████║██╔██╗██║█████═╝░██║██╔██╗██║██║░░██╗░
    ██╔══╝░░╚═╝██║░░  ██╔══██╗██╔══██║██║╚████║██╔═██╗░██║██║╚████║██║░░╚██╗
    ██║░░░░░███████╗  ██║░░██║██║░░██║██║░╚███║██║░╚██╗██║██║░╚███║╚██████╔╝
    ╚═╝░░░░░╚══════╝  ╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝░╚═════╝░
    ");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para Iniciar campeonato");
    Console.WriteLine("Digite 2 para Adicionar piloto");
    Console.WriteLine("Digite 3 para Alterar piloto");
    Console.WriteLine("Digite 4 para Remover piloto");
    Console.WriteLine("Digite 5 para Adicionar corrida");
    Console.WriteLine("Digite 6 para Adicionar pontuação de corrida");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(campeonato);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();
