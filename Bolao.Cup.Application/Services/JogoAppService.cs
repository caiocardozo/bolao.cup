using Bolao.Cup.Application.Interfaces;
using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Application.Services
{
    public class JogoAppService : AppServiceBase<Jogo>, IJogoAppService
    {
        private readonly IJogoService _jogoService;

        public JogoAppService(IJogoService jogoService)
            : base(jogoService)
        {
            _jogoService = jogoService;
        }

    }
}
