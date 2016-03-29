using DependencyInjection.Domain.Interfaces;
using DependencyInjection.Domain.Modelo;
using StructureMap;

namespace DependencyInjection.Structure_Map.Kernel
{
    public class StructureMapKernel : IInjectionKernel
    {
        private readonly IContainer _container;

        public StructureMapKernel()
        {
            _container = new Container(x =>
            {
                x.For<ISamurai>().Use<Samurai>();
                x.For<IArma>().Use<Espada>();
            });
        }

        public T ObterInstancia<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}
