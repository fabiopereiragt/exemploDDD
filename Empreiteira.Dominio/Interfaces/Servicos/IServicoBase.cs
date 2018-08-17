using Empreiteira.Dominio.Entidades;
using System.Collections.Generic;

namespace Empreiteira.Dominio.Interfaces.Servicos
{
    public interface IServicoBase<TEntity> where TEntity : class
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
