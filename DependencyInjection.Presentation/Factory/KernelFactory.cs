using DependencyInjection.Domain.Interfaces;
using DependencyInjection.Ninject.Kernel;
using DependencyInjection.Simple_Injector.Kernel;
using DependencyInjection.Structure_Map.Kernel;
using DependencyInjection.UnityApplicationBlock.Kernel;
using System;

namespace DependencyInjection.Presentation.Factory
{
    public class KernelFactory
    {
        public static IInjectionKernel GetKernel(TipoKernel tipoKernel)
        {
            switch (tipoKernel)
            {
                case TipoKernel.Ninject:
                    return new NinjectKernel();

                case TipoKernel.SimpleInjector:
                    return new SimpleInjectorKernel();

                case TipoKernel.Unity:
                    return new UnityKernel();

                case TipoKernel.StructureMap:
                    return new StructureMapKernel();
            }

            throw new Exception("Parâmetro inválido");
        }
    }
}
