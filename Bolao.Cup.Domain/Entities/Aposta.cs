namespace Bolao.Cup.Domain.Entities
{
    public class Aposta
    {
        public int cod_aposta { get; set; }

        public int cod_user { get; set; }

        public int cod_jogo { get; set; }

        public int cas_aposta { get; set; }

        public int vis_aposta { get; set; }

        public virtual Jogo Jogo { get; set; }
    }
}
