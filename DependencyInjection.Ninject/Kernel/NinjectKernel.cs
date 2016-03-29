using DependencyInjection.Domain.Interfaces;
using DependencyInjection.Ninject.Modulo;
using Ninject;

namespace DependencyInjection.Ninject.Kernel
{
    public class NinjectKernel : IInjectionKernel
    {
        private IKernel _kernel = new StandardKernel(new NinjectContainer());

        public T ObterInstancia<T>()
        {
            return _kernel.Get<T>();
        }
    }
}
