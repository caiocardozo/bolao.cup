using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Infra.Data.Mappings;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Bolao.Cup.Infra.Data.Context
{
    public class Context : DbContext, IContext
    {
        public Context() : base("StoreConnectionString")//nome da string de conexao
        {
        }

        public DbSet<Campeonato> Campeonato { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Clube> Clube { get; set; }
        public DbSet<Pontuacao> Pontuacao { get; set; }
        public DbSet<Pontuacao_Rodada> PontuacaoRodada { get; set; }
        public DbSet<Rodada> Rodada { get; set; }
        public DbSet<Aposta> Aposta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//impede que crie o nome das tabelas no plural
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//impede que os registros sejam deletados em cascata
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();//impede que os registros sejam deletados em cascata

            //seta todos atributos que forem string para varchar ao inves de criar com o padrão nvarchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //caso nao seja passado por parametro o tamanho do campo string seta ele com tamanho 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ApostaConfiguration());
            modelBuilder.Configurations.Add(new ClubeConfiguration());
            modelBuilder.Configurations.Add(new JogoConfiguration());
            modelBuilder.Configurations.Add(new PontuacaoConfiguration());
            modelBuilder.Configurations.Add(new RodadaConfiguration());
            modelBuilder.Configurations.Add(new PontuacaoRodadaConfiguration());
            modelBuilder.Configurations.Add(new CampeonatoConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());

        }
    }
}
