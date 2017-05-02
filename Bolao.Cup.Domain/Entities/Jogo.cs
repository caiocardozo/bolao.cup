using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolao.Cup.Domain.Entities
{
   public class Jogo
    {
        public int cod_jogo { get; set; }

        public int cod_rodada { get; set; }

        public int cas_clube { get; set; }

        public int casres_jogo { get; set; }

        public int vis_clube { get; set; }

        public int visres_jogo { get; set; }

        public virtual Clube ClubeCas { get; set; }

        public virtual Clube ClubeVis { get; set; }

        public virtual Aposta Aposta { get; set; }

        public virtual Rodada Rodada { get; set; }
    }
}
