using System.Collections.Generic;

namespace Bolao.Cup.Domain.Entities
{
    public class Clube
    {
        public int cod_clube { get; set; }

        public string des_clube { get; set; }

        public virtual ICollection<Jogo> Jogo { get; set; }

        public virtual ICollection<Jogo> JogoCasa { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
