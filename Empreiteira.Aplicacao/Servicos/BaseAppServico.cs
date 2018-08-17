using Empreiteira.Aplicacao.Interfaces;
using Empreiteira.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace Empreiteira.Aplicacao.Servicos
{
    public class BaseAppServico<TEntity, TEntityDTO> : IDisposable, IBaseAppServico<TEntity, TEntityDTO> where TEntity : class where TEntityDTO : class
    {

        private readonly IServicoBase<TEntity> _servicoBase;

        public BaseAppServico(IServicoBase<TEntity> servicoBase)
        {
            _servicoBase = servicoBase;
        }
        
        public bool Adicionar(TEntity obj)
        {
            return _servicoBase.Adicionar(obj);
        }

        public bool Atualizar(TEntity obj)
        {
            return _servicoBase.Atualizar(obj);
        }

        public int Count(object where = null)
        {
            return _servicoBase.Count(where);
        }

        public bool Excluir(TEntity obj)
        {
            return _servicoBase.Excluir(obj);
        }

        public IEnumerable<TEntity> SelecionarPor(object where = null)
        {
            return SelecionarPor(where);
        }

        public TEntity SelecionarPorId(int id)
        {
            return SelecionarPorId(id);
        }

        public IEnumerable<TEntity> SelecionarTodos()
        {
            return SelecionarTodos();
        }

        public void Dispose()
        {
            _servicoBase.Dispose();
        }
    }
}
