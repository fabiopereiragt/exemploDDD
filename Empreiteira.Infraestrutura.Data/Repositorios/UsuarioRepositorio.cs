using Empreiteira.Dominio.Entidades;
using Empreiteira.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empreiteira.Infraestrutura.Data.Interfaces;

namespace Empreiteira.Infraestrutura.Data.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(IDapperContexto context, IUnitOfWork uow) : base(context, uow)
        {
        }
    }
}
