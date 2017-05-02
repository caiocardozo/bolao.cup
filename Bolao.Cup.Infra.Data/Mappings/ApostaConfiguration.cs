using Bolao.Cup.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace Bolao.Cup.Infra.Data.Mappings
{
   public class ApostaConfiguration : EntityTypeConfiguration<Aposta>
    {
        public ApostaConfiguration()
        {
            HasKey(a => a.cod_aposta);

            Property(c => c.cod_aposta)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.cod_user)
                .IsRequired();

            Property(a => a.cod_jogo)
                .IsRequired();

            Property(a => a.cas_aposta)
                .IsRequired();

            Property(a => a.vis_aposta)
                .IsRequired();

            // MAPEAMENTO DE UM PARA UM
            HasRequired(p => p.Jogo)
                .WithRequiredPrincipal(p => p.Aposta);

            //mapeia o relacionamento 1 to N com Aposta
            HasRequired(t => t.Usuario)
           .WithMany(t => t.Apostas)
           .HasForeignKey(t => t.cod_user);
        }
    }
}
