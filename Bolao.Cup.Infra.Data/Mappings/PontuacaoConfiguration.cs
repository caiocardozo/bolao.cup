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

            Property(p => p.pos_pontuacao)
                .IsRequired();

            HasRequired(t => t.Campeonato)
             .WithMany(t => t.Pontuacao)
             .HasForeignKey(t => t.cod_campeonato);

            HasRequired(t => t.Usuario)
             .WithMany(t => t.Pontuacao)
             .HasForeignKey(t => t.cod_user);
        }
    }
}
