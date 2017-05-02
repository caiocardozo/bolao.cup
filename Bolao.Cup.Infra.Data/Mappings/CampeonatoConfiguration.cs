using Bolao.Cup.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bolao.Cup.Infra.Data.Mappings
{
    public class CampeonatoConfiguration : EntityTypeConfiguration<Campeonato>
    {
        public CampeonatoConfiguration()
        {
            HasKey(c => c.cod_campeonato);

            Property(c => c.cod_campeonato)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.nom_campeonato)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.ini_campeonato)
                .IsRequired();

            Property(c => c.fim_campeonato)
                .IsRequired();

            Property(c => c.sit_campeonato)
                .IsRequired()
                .HasMaxLength(7);

            
        }
    }
}
