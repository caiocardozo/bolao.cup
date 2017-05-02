using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuariorepository;

        public UsuarioService(IUsuarioRepository usuariorepository)
             : base(usuariorepository)
        {
            _usuariorepository = usuariorepository;
        }
    }
}
