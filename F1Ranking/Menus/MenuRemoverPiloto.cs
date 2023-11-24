using F1Ranking.Entities;
using System;
using System.Collections.Generic;

namespace F1Ranking.Menus
{
    internal class MenuRemoverPiloto : Menu
    {
        public override void Executar(Dictionary<string, Campeonato> campeonato)
        {
            base.Executar(campeonato);

            ExibirTituloDaOpcao("Remover Piloto");

            Campeonato campeonatoPiloto = new Campeonato();
            Console.Write("Digite o nome do piloto que deseja remover: ");
            string nomePiloto = Console.ReadLine();

            Piloto pilotoParaRemover = campeonatoPiloto.Piloto.Find(p => p.Nome.Equals(nomePiloto, StringComparison.OrdinalIgnoreCase));
           
            if (pilotoParaRemover != null)
            {
                campeonatoPiloto.RemoverPiloto(pilotoParaRemover);
                Console.WriteLine($"O Piloto {nomePiloto} foi removido com sucesso do campeonato.");
            }
            else
            {
                Console.WriteLine($"Piloto {nomePiloto} não encontrado no campeonato.");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
