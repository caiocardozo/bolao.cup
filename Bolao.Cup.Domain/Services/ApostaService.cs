using Bolao.Cup.Domain.Entities;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;

namespace Bolao.Cup.Domain.Services
{
   public class ApostaService : ServiceBase<Aposta>, IApostaService
    {
        private readonly IApostaRepository _apostarepository;

        public ApostaService(IApostaRepository apostarepository)
             : base(apostarepository)
        {
            _apostarepository = apostarepository;
        }
    }
}
