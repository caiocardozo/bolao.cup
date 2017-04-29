using Bolao.Cup.Application.Interfaces;
using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Application.Services
{
    public class PontuacaoRodadaAppService : AppServiceBase<Pontuacao_Rodada>, IPontuacaoRodadaAppService
    {
        private readonly IPontuacaoRodadaService _pontuacaoRodadaService;

        public PontuacaoRodadaAppService(IPontuacaoRodadaService pontuacaoRodadaService)
            : base(pontuacaoRodadaService)
        {
            _pontuacaoRodadaService = pontuacaoRodadaService;
        }

    }
}
