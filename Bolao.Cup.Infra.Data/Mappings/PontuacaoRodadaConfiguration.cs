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

            HasRequired(t => t.Rodada)
             .WithMany(t => t.PontuacaoRodada)
             .HasForeignKey(t => t.cod_rodada);

            HasRequired(t => t.Usuario)
            .WithMany(t => t.PontuacaoRodada)
            .HasForeignKey(t => t.cod_user);
        }
    }
}