using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Ranking.Entities
{
    internal class Campeonato
    {
        public string NomeDoCampeonato { get; set; }
        public int QuantidadeDeCorridas { get; set; }
        public List<Piloto> Piloto { get; set; } = new List<Piloto>();
        public List<Corrida> Corrida { get; set; } = new List<Corrida>();
        public List<Pontos> Pontos { get; set; } = new List<Pontos>();

        public Campeonato() { }

        public Campeonato(string nomeDoCampeonato, int quantidadeDeCorridas)
        {
            NomeDoCampeonato = nomeDoCampeonato;
            QuantidadeDeCorridas = quantidadeDeCorridas;
        }
   
        public void AdicionarPiloto(Piloto novoPiloto)
        {
            if (Piloto.Any(p => p.Nome == novoPiloto.Nome))
            {
                Console.WriteLine($"\nO piloto {novoPiloto.Nome} já está inscrito no campeonato.");
            }
            else
            {
                Piloto.Add(novoPiloto);
            }
        }
    
        public void RemoverPiloto(Piloto novoPiloto)
        {
            if (Piloto.Any(p => p.Nome == novoPiloto.Nome))
            {
                Console.WriteLine($"\nO piloto {novoPiloto.Nome} foi removido do campeonato.");
                Piloto.Remove(novoPiloto);
            }
            else
            {
                Console.WriteLine($"O Piloto {novoPiloto.Nome} não existe no campeonato.");
            }
        }
    
    }
}
