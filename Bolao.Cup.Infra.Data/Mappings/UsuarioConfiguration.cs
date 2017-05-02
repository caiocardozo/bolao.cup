using Bolao.Cup.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bolao.Cup.Infra.Data.Mappings
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            Property(u => u.Senha)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnType("varchar");

            Property(u => u.Status)
               .IsRequired()
               .HasMaxLength(7)
               .HasColumnType("varchar");

            Property(u => u.AlteraSenha)
               .IsRequired()
               .HasMaxLength(1)
               .HasColumnType("varchar");

            Property(u => u.DataCadastro)
               .IsRequired();

            HasRequired(t => t.ClubeFavorito)
             .WithMany(t => t.Usuario)
             .HasForeignKey(t => t.TimeFavorito);
        }
    }
}
