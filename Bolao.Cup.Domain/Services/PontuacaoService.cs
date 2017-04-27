using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Domain.Services
{
    public class PontuacaoService : ServiceBase<Pontuacao>, IPontuacaoService
    {
        private readonly IPontuacaoRepository _pontuacaorepository;

        public PontuacaoService(IPontuacaoRepository pontuacaorepository)
             : base(pontuacaorepository)
        {
            _pontuacaorepository = pontuacaorepository;
        }
    }
}
