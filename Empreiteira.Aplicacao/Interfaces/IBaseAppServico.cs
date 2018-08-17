using System.Collections.Generic;

namespace Empreiteira.Aplicacao.Interfaces
{
    public interface IBaseAppServico<TEntity, TEntityDTO>
    {
        bool Adicionar(TEntity obj);
        bool Atualizar(TEntity obj);
        bool Excluir(TEntity obj);
        TEntity SelecionarPorId(int id);
        IEnumerable<TEntity> SelecionarPor(object where = null);
        IEnumerable<TEntity> SelecionarTodos();
        int Count(object @where = null);

        void Dispose();
    }
}
