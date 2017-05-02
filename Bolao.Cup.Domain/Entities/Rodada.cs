using System.Collections.Generic;

namespace Bolao.Cup.Domain.Entities
{
    public class Rodada
    {
        public int cod_rodada { get; set; }

        public string des_rodada { get; set; }

        public int peso_rodada { get; set; }

        public int cod_campeonato { get; set; }

        public virtual Campeonato Campeonato { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }

        public virtual ICollection<Pontuacao_Rodada> PontuacaoRodada { get; set; }

    }
}
