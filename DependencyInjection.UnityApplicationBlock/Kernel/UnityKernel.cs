using DependencyInjection.Domain.Interfaces;
using DependencyInjection.Domain.Modelo;
using Microsoft.Practices.Unity;

namespace DependencyInjection.UnityApplicationBlock.Kernel
{
    public class UnityKernel : IInjectionKernel
    {
        private readonly IUnityContainer _container = new UnityContainer();

        public UnityKernel()
        {
            _container.RegisterType<ISamurai, Samurai>();
            _container.RegisterType<IArma, Espada>();
        }

        public T ObterInstancia<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
