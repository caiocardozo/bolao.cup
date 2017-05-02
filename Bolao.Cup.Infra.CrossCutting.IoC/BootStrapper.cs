using Bolao.Cup.Application.Interfaces;
using Bolao.Cup.Application.Services;
using Bolao.Cup.Domain.Interfaces.Repositories;
using Bolao.Cup.Domain.Interfaces.Services;
using Bolao.Cup.Domain.Services;
using Bolao.Cup.Infra.Data.Repositories;
using SimpleInjector;
using System.Runtime.Remoting.Contexts;

namespace Bolao.Cup.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.RegisterPerWebRequest<Context>();
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
        }
    }
}
