using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;


namespace Bolao.Cup.Domain.Services
{
    public class RodadaService : ServiceBase<Rodada>, IRodadaService
    {
        private readonly IRodadaRepository _rodadarepository;

        public RodadaService(IRodadaRepository rodadarepository)
             : base(rodadarepository)
        {
            _rodadarepository = rodadarepository;
        }
    }
}
