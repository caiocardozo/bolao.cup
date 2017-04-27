using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Domain.Services
{
    public class ClubeService : ServiceBase<Clube>, IClubeService
    {
        private readonly IClubeRepository _cluberepository;

        public ClubeService(IClubeRepository cluberepository)
             : base(cluberepository)
        {
            _cluberepository = cluberepository;
        }
    }
}
