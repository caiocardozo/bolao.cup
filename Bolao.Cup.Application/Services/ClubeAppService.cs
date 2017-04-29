using Bolao.Cup.Application.Interfaces;
using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Application.Services
{
    public class ClubeAppService : AppServiceBase<Clube>, IClubeAppService
    {
        private readonly IClubeService _clubeService;

        public ClubeAppService(IClubeService clubeService)
            : base(clubeService)
        {
            _clubeService = clubeService;
        }
    }
    }
