using System.Data;

namespace Empreiteira.Infraestrutura.Data.Interfaces
{
    public interface IDapperContexto
    {
        IDbConnection Connection { get; }
        void Dispose();
    }
}
