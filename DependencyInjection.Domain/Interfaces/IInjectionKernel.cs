namespace DependencyInjection.Domain.Interfaces
{
    public interface IInjectionKernel
    {
        T ObterInstancia<T>();
    }
}
