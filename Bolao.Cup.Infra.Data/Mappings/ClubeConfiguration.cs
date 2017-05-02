using Bolao.Cup.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bolao.Cup.Infra.Data.Mappings
{
    public class ClubeConfiguration : EntityTypeConfiguration<Clube>
    {
        public ClubeConfiguration()
        {
            HasKey(c => c.cod_clube);

            Property(c => c.cod_clube)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.des_clube)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
    }
}
