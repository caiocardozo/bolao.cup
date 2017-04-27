using System.Collections.Generic;

namespace Bolao.Cup.Domain.Entities
{
    public class Rodada
    {
        public int cod_rodada { get; set; }

        public string des_rodada { get; set; }

        public int peso_rodada { get; set; }

        public int cod_campeonato { get; set; }
        public Campeonato Campeonato { get; set; }

        public ICollection<Jogo> Jogos { get; set; }

        public Pontuacao_Rodada PontuacaoRodada { get; set; }

    }
}
