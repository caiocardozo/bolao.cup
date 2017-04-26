using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Bolao.Cup.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        //aqui rabalha com objetos genericos
        protected IContext _db;

        public RepositoryBase(IContext faiContext)
        {
            _db = faiContext;
        }

        public void Add(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            _db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            //retornando um objeto
            return _db.Set<TEntity>().Find(id);//find busca pela chave primaria pelo Id ali passado
        }

        public IEnumerable<TEntity> GetAll()
        {
            //retornando varios objetos
            return _db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            //realiza o update seta o objeto como modificado
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            //remove o objeto
            _db.Set<TEntity>().Remove(obj);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
