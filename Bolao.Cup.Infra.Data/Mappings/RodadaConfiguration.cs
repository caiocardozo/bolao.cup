using Bolao.Cup.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Bolao.Cup.Infra.Data.Mappings
{
    public class RodadaConfiguration : EntityTypeConfiguration<Rodada>
    {
        public RodadaConfiguration()
        {
            HasKey(r => r.cod_rodada);

            Property(r => r.des_rodada)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            Property(r => r.cod_campeonato)
                .IsRequired();

            Property(r => r.peso_rodada)
                .IsRequired();

            HasRequired(t => t.Campeonato)
             .WithMany(t => t.Rodada)
             .HasForeignKey(t => t.cod_campeonato);
        }
    }
}
