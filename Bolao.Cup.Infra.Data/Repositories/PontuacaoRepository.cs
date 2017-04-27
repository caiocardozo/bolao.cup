using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Infra.Data.Context;

namespace Bolao.Cup.Infra.Data.Repositories
{
    public class PontuacaoRepository : RepositoryBase<Pontuacao>, IPontuacaoRepository
    {

        public PontuacaoRepository(IContext context)
            : base(context)
        {
        }
    }
}