using Bolao.Cup.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Bolao.Cup.Infra.Data.Context
{
    public interface IContext
    {
        DbEntityEntry Entry(object entity);
        int SaveChanges();
        DbSet<T> Set<T>() where T : class;

        DbSet<Campeonato> Campeonato { get; set; }
        DbSet<Jogo> Jogo { get; set; }
        DbSet<Clube> Clube { get; set; }
        DbSet<Pontuacao> Pontuacao { get; set; }
        DbSet<Pontuacao_Rodada> PontuacaoRodada { get; set; }
        DbSet<Rodada> Rodada { get; set; }
        DbSet<Aposta> Aposta { get; set; }
    }
}
