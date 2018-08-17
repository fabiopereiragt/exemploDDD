using System.Data;

namespace Empreiteira.Infraestrutura.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IDapperContexto Context { get; }
        IDbTransaction Transaction { get; }
        IDbTransaction BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);
        void Commit();
        void Rollback();
    }
}
