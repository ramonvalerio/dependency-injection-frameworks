using DependencyInjection.Domain.Interfaces;
using DependencyInjection.Presentation.Factory;
using System;

namespace DependencyInjection.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var structureMapKernel = KernelFactory.GetKernel(TipoKernel.StructureMap);
            var ninjectKernel = KernelFactory.GetKernel(TipoKernel.Ninject);
            var simpleInjectorKernel = KernelFactory.GetKernel(TipoKernel.SimpleInjector);
            var unityKernel = KernelFactory.GetKernel(TipoKernel.Unity);

            var samurai = structureMapKernel.ObterInstancia<ISamurai>();
            Console.WriteLine("StructureMap: {0}", samurai.Atacar());

            samurai = ninjectKernel.ObterInstancia<ISamurai>();
            Console.WriteLine("Ninject: {0}", samurai.Atacar());

            samurai = simpleInjectorKernel.ObterInstancia<ISamurai>();
            Console.WriteLine("SimpleInjector: {0}", samurai.Atacar());

            samurai = unityKernel.ObterInstancia<ISamurai>();
            Console.WriteLine("Unity: {0}", samurai.Atacar());

            Console.ReadLine();
        }
    }
}
