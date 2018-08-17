using System;
using Empreiteira.Dominio.Interfaces.Servicos;
using System.Collections.Generic;
using Empreiteira.Dominio.Interfaces.Repositorios;

namespace Empreiteira.Dominio.Servicos
{
    public class ServicoBase<TEntity> : IDisposable, IServicoBase<TEntity> where TEntity : class
    {

        private readonly IRepositorioBase<TEntity> _repositorio;

        public ServicoBase(IRepositorioBase<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public bool Adicionar(TEntity obj)
        {
           return _repositorio.Adicionar(obj);
        }

        public bool Atualizar(TEntity obj)
        {
            return _repositorio.Atualizar(obj);
        }

        public int Count(object where = null)
        {
            return _repositorio.Count(where);
        }      

        public bool Excluir(TEntity obj)
        {
            return _repositorio.Excluir(obj);
        }

        public IEnumerable<TEntity> SelecionarPor(object where = null)
        {
            return _repositorio.SelecionarPor(where);
        }

        public TEntity SelecionarPorId(int id)
        {
            return _repositorio.SelecionarPorId(id);
        }

        public IEnumerable<TEntity> SelecionarTodos()
        {
            return _repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }
    }
}
