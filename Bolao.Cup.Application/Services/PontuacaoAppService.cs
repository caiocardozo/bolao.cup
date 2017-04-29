using Bolao.Cup.Application.Interfaces;
using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Application.Services
{
    public class PontuacaoAppService : AppServiceBase<Pontuacao>, IPontuacaoAppService
    {
        private readonly IPontuacaoService _pontuacaoService;

        public PontuacaoAppService(IPontuacaoService pontuacaoService)
            : base(pontuacaoService)
        {
            _pontuacaoService = pontuacaoService;
        }

    }
}
