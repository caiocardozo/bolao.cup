using Bolao.Cup.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Bolao.Cup.Infra.Data.Mappings
{
    public class PontuacaoConfiguration : EntityTypeConfiguration<Pontuacao>
    {
        public PontuacaoConfiguration()
        {
            HasKey(p => new { p.cod_campeonato, p.cod_user });

            Property(p => p.pos_anterior)
                .IsRequired();

            Property(p => p.pos_atual)
                .IsRequired();

            Property(p => p.pontuacao)
                .IsRequired();

            // MAPEAMENTO DE UM PARA UM
            HasRequired(p => p.Campeonato)
                .WithRequiredPrincipal(p => p.Pontuacao);
        }
    }
}
