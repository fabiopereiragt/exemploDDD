using Empreiteira.Aplicacao.DTO;
using Empreiteira.Dominio.Entidades;
using AutoMapper;

namespace Empreiteira.Aplicacao.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DTOToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioDTO, Usuario>();            
        }
    }
}
