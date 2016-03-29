using DependencyInjection.Domain.Interfaces;
using DependencyInjection.Domain.Modelo;
using Ninject.Modules;

namespace DependencyInjection.Ninject.Modulo
{
    public class NinjectContainer : NinjectModule
    {
        public override void Load()
        {
            Bind<ISamurai>().To<Samurai>();
            Bind<IArma>().To<Espada>();
        }
    }
}
