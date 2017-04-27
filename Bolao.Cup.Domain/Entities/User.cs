using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolao.Cup.Domain.Entities
{
    public class User
    {
        public int nom_user { get; set; }

        public string ema_user { get; set; }

        public string sen_user { get; set; }

        public string sit_user { get; set; }

        public virtual Pontuacao_Rodada PontuacaoRodada {get; set; }

        public virtual Aposta Aposta { get; set; }
    }
}
