using F1Ranking.Entities;
using System;
using System.Collections.Generic;

namespace F1Ranking.Menus
{
    internal class MenuAdicionarPiloto : Menu
    {
        public override void Executar(Dictionary<string, Campeonato> campeonato)
        {
            base.Executar(campeonato);

            ExibirTituloDaOpcao("Adicionar Piloto");
            Campeonato campeonatoPiloto = new Campeonato();

            Console.Write("Quantos pilotos você deseja adicionar ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"\nDados do Piloto {i}:");
                Console.Write("\nDigite o nome do piloto que deseja adicionar: ");
                string nome = Console.ReadLine();   

                Console.Write("Digite o número do carro do piloto: ");
                int numeroCarro = int.Parse(Console.ReadLine());

                Console.Write("Digite os pontos atuais do piloto: ");
                int pontosPiloto = int.Parse(Console.ReadLine());

                Piloto novoPiloto = new Piloto(nome, numeroCarro, pontosPiloto);
                campeonatoPiloto.AdicionarPiloto(novoPiloto);

                Console.WriteLine($"\nO Piloto {nome} foi registrado com sucesso!");
            }

            Console.WriteLine("\nPilotos registrados: ");
            Console.WriteLine();

            foreach (Piloto piloto in campeonatoPiloto.Piloto)
            {
                Console.WriteLine($"Nome: {piloto.Nome}, Número do Carro: {piloto.NumeroDoCarro}, Pontos: {piloto.Pontos}");
            }


            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
