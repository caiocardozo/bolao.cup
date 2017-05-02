using System;
using System.Collections.Generic;

namespace Bolao.Cup.Domain.Entities
{
    public class Pontuacao_Rodada
    {
        public int cod_rodada { get; set; }
       
        public int cod_user { get; set; }
      
        public int pos_atual { get; set; }

        public int pos_anterior { get; set; }

        public int pontuacao { get; set; }

        public virtual Rodada Rodada { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
