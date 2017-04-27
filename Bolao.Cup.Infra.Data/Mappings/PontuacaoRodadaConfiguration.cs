using Bolao.Cup.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Bolao.Cup.Infra.Data.Mappings
{
    public class PontuacaoRodadaConfiguration : EntityTypeConfiguration<Pontuacao_Rodada>
    {
        public PontuacaoRodadaConfiguration()
        {
            HasKey(p => new { p.cod_rodada, p.cod_user });

            Property(p => p.pos_anterior)
                .IsRequired();

            Property(p => p.pos_atual)
                .IsRequired();

            Property(p => p.pontuacao)
                .IsRequired();

            // MAPEAMENTO DE UM PARA UM
            HasRequired(p => p.Rodada)
                .WithRequiredPrincipal(p => p.PontuacaoRodada);

            // MAPEAMENTO DE UM PARA UM
            HasRequired(p => p.User)
                .WithRequiredPrincipal(p => p.PontuacaoRodada);
        }
    }
}
