using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Domain.Services
{
    public class JogoService : ServiceBase<Jogo>, IJogoService
    {
        private readonly IJogoRepository _jogorepository;

        public JogoService(IJogoRepository jogorepository)
             : base(jogorepository)
        {
            _jogorepository = jogorepository;
        }
    }
}
