using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Domain.Services
{
    class PontuacaoRodadaService : ServiceBase<Pontuacao_Rodada>, IPontuacaoRodadaService
    {
        private readonly IPontuacaoRodadaRepository _pontuacaoRodadarepository;

        public PontuacaoRodadaService(IPontuacaoRodadaRepository pontuacaoRodadarepository)
             : base(pontuacaoRodadarepository)
        {
            _pontuacaoRodadarepository = pontuacaoRodadarepository;
        }
    }
}
