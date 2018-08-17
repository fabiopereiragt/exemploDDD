using AutoMapper;
using Empreiteira.Aplicacao.DTO;
using Empreiteira.Dominio.Entidades;

namespace Empreiteira.Aplicacao.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToDTOMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Usuario, UsuarioDTO>();
            //Mapper.CreateMap<TipoUsuario, TipoUsuarioDTO>();
        }
    }
}
