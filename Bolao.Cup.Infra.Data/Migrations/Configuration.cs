namespace Bolao.Cup.Infra.Data.Migrations
{
    using Bolao.Cup.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bolao.Cup.Infra.Data.Context.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bolao.Cup.Infra.Data.Context.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Clube.AddOrUpdate(
              p => p.cod_clube,
              new Clube { des_clube = "Atlético GO" },
              new Clube { des_clube = "Atlético MG" },
              new Clube { des_clube = "Atlético PR" },
              new Clube { des_clube = "Avaí" },
              new Clube { des_clube = "Bahia" },
              new Clube { des_clube = "Botafogo" },
              new Clube { des_clube = "Chapecoense" },
              new Clube { des_clube = "Corinthians" },
              new Clube { des_clube = "Coritiba" },
              new Clube { des_clube = "Cruzeiro" },
              new Clube { des_clube = "Flamengo" },
              new Clube { des_clube = "Fluminense" },
              new Clube { des_clube = "Grêmio" },
              new Clube { des_clube = "Palmeiras" },
              new Clube { des_clube = "Ponte Preta" },
              new Clube { des_clube = "Santos" },
              new Clube { des_clube = "São Paulo" },
              new Clube { des_clube = "Sport" },
              new Clube { des_clube = "Vasco" },
              new Clube { des_clube = "Vitória" }
            );

            context.Campeonato.AddOrUpdate(
              p => p.cod_campeonato,
              new Campeonato { nom_campeonato = "Campeonato Brasileiro 2017",
              fim_campeonato = DateTime.Now,
              ini_campeonato = DateTime.Now,
              sit_campeonato = "Ativo"
              }
              
            );
            //
        }
    }
}
