using DependencyInjection.Domain.Interfaces;
using DependencyInjection.Domain.Modelo;
using SimpleInjector;

namespace DependencyInjection.Simple_Injector.Kernel
{
    public class SimpleInjectorKernel : IInjectionKernel
    {
        private readonly Container _container = new Container();

        public SimpleInjectorKernel()
        {
            _container.Register<ISamurai, Samurai>();
            _container.Register<IArma, Espada>();
        }

        public T ObterInstancia<T>()
        {
            return (T)_container.GetInstance(typeof(T));
        }
    }
}
