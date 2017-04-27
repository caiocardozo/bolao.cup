using Bolao.Cup.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bolao.Cup.Infra.Data.Mappings
{
    public class JogoConfiguration : EntityTypeConfiguration<Jogo>
    {
        public JogoConfiguration()
        {
            HasKey(j => j.cod_jogo);

            Property(c => c.cod_jogo)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(j => j.cod_rodada)
                .IsRequired();

            Property(j => j.cas_clube)
                .IsRequired();

            Property(j => j.vis_clube)
                .IsRequired();

            //mapeia o relacionamento 1 to N com Clube
            HasRequired(t => t.ClubeCas)
           .WithMany(t => t.Jogo)
           .HasForeignKey(t => t.cas_clube);

            HasRequired(t => t.ClubeVis)
           .WithMany(t => t.Jogo)
           .HasForeignKey(t => t.vis_clube);

            HasRequired(t => t.Rodada)
           .WithMany(t => t.Jogos)
           .HasForeignKey(t => t.cod_rodada);
        }
    }
}
