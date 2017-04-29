using Bolao.Cup.Application.Interfaces;
using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Application.Services
{
    public class RodadaAppService : AppServiceBase<Rodada>, IRodadaAppService
    {
        private readonly IRodadaService _rodadaService;

        public RodadaAppService(IRodadaService rodadaService)
            : base(rodadaService)
        {
            _rodadaService = rodadaService;
        }

    }
}
