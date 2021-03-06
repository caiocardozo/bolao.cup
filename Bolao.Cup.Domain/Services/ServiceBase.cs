﻿using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Bolao.Cup.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        //aqui nao pode adicionar uma instancia de repositorio para nao perder a ideia de isolar fazendo assim perde a funcionalidade do dominio
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
