using Empreiteira.Dominio.Entidades;
using Empreiteira.Dominio.Interfaces.Repositorios;
using Empreiteira.Dominio.Interfaces.Servicos;

namespace Empreiteira.Dominio.Servicos
{
    public class UsuarioServico : ServicoBase<Usuario>, IUsuarioServico
    {
        private readonly IUsuarioRepositorio _repositorio;

        public UsuarioServico(IUsuarioRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
