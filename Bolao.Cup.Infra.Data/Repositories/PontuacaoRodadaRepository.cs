using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Infra.Data.Context;
namespace Bolao.Cup.Infra.Data.Repositories
{
    public class PontuacaoRodadaRepository : RepositoryBase<Pontuacao_Rodada>, IPontuacaoRodadaRepository
    {

        public PontuacaoRodadaRepository(IContext context)
            : base(context)
        {
        }
    }
}
