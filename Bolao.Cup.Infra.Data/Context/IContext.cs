using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Bolao.Cup.Infra.Data.Context
{
    public interface IContext
    {
        DbEntityEntry Entry(object entity);
        int SaveChanges();
        DbSet<T> Set<T>() where T : class;
    }
}
