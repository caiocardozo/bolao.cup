using System;
using System.Collections.Generic;

namespace Bolao.Cup.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Status { get; set; }

        public string AlteraSenha { get; set; }

        public DateTime DataCadastro { get; set; }

        public int TimeFavorito { get; set; }

        public virtual Clube ClubeFavorito { get; set; }

        public virtual ICollection<Pontuacao_Rodada> PontuacaoRodada {get; set; }

        public virtual ICollection<Pontuacao> Pontuacao { get; set; }

        public virtual ICollection<Aposta> Apostas { get; set; }


    }
}
