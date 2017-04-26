using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Bolao.Cup.Infra.Data.Context
{
    public class Context : DbContext, IContext
    {
        public Context()
            : base() //nome da string de conexao
        //: base("name=OracleDbContextSapiens") //nome da string de conexao
        //: base(new OracleConnection(ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString), true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.HasDefaultSchema("SITEPRODUCAO");
            // modelBuilder.HasDefaultSchema("SITETESTE");
            // modelBuilder.HasDefaultSchema("SAPIENSPRODUCAO");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//impede que crie o nome das tabelas no plural
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//impede que os registros sejam deletados em cascata
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();//impede que os registros sejam deletados em cascata

            //seta como padrão as propriedades com id para primari key
            //modelBuilder.Properties()
            //    .Where(p => p.Name == p.ReflectedType.Name + "id")
            //    .Configure(p => p.IsKey());

            //seta todos atributos que forem string para varchar ao inves de criar com o padrão nvarchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //caso nao seja passado por parametro o tamanho do campo string seta ele com tamanho 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }
    }
}
