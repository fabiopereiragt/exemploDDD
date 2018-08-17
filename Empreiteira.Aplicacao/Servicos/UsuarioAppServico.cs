using Empreiteira.Aplicacao.DTO;
using Empreiteira.Aplicacao.Interfaces;
using Empreiteira.Dominio.Entidades;
using Empreiteira.Dominio.Interfaces.Servicos;

namespace Empreiteira.Aplicacao.Servicos
{
    public class UsuarioAppServico : BaseAppServico<Usuario, UsuarioDTO>, IUsuarioAppServico
    {
        private readonly IUsuarioServico _servico;

        public UsuarioAppServico(IUsuarioServico servico) : base(servico)
        {
            _servico = servico;
        }
    }
}
