using System;

namespace Bolao.Cup.Domain.Entities
{
    public class Pontuacao
    {
        public int cod_campeonato { get; set; }

        public int cod_user { get; set; }

        public int pos_atual { get; set; }

        public int pos_anterior { get; set; }

        public int pos_pontuacao { get; set; }

        public virtual Campeonato Campeonato { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}
