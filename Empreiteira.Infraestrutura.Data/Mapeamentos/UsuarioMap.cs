using DapperExtensions.Mapper;
using Empreiteira.Dominio.Entidades;


namespace Empreiteira.Infraestrutura.Data.Mapeamentos
{
    public class UsuarioMap : ClassMapper<Usuario>
    {
        public UsuarioMap()
        {
            Table("usuarios");

            Map(p => p.Id).Key(KeyType.Identity).Column("ID");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Email).Column("Email");
            Map(p => p.Login).Column("Login");
            Map(p => p.Senha).Column("Senha");
            Map(p => p.Ativo).Column("Ativo");
            Map(p => p.DataCadastro).Column("DataCadastro");

        }
    }
}
