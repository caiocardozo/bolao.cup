using System.Collections.Generic;


namespace Bolao.Cup.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        //chamadas genericas repositori base faz crud padrao

        //adiciona no banco de dados o obj
        void Add(TEntity obj);

        //seleciona por ID
        TEntity GetById(int id);

        //retorna um Ienumerable
        IEnumerable<TEntity> GetAll();

        //realiza update recebendo objeto
        void Update(TEntity obj);

        //realiza delete recebendo objeto
        void Remove(TEntity obj);

        //dispose força a implementar 
        void Dispose();
    }
}
