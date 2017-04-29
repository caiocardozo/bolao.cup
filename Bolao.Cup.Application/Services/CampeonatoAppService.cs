using Bolao.Cup.Application.Interfaces;
using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Services;


namespace Bolao.Cup.Application.Services
{
    public class CampeonatoAppService : AppServiceBase<Campeonato>, ICampeonatoAppService
    {
        private readonly ICampeonatoService _campeonatoService;

        public CampeonatoAppService(ICampeonatoService campeonatoService)
            : base(campeonatoService)
        {
            _campeonatoService = campeonatoService;
        }

    }
}
