using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Domain.Services
{
    public class CampeonatoService : ServiceBase<Campeonato>, ICampeonatoService
    {
        private readonly ICampeonatoRepository _campeonatorepository;

        public CampeonatoService(ICampeonatoRepository campeonatorepository)
             : base(campeonatorepository)
        {
            _campeonatorepository = campeonatorepository;
        }
    }
}
