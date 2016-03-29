using DependencyInjection.Domain.Interfaces;

namespace DependencyInjection.Domain.Modelo
{
    public class Espada : IArma
    {
        public string Acao()
        {
            return "Espadada frontal";
        }
    }
}
