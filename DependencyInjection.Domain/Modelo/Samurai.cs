using DependencyInjection.Domain.Interfaces;

namespace DependencyInjection.Domain.Modelo
{
    public class Samurai : ISamurai
    {
        private readonly IArma _arma;

        public Samurai(IArma arma)
        {
            _arma = arma;
        }

        public string Atacar()
        {
            return _arma.Acao();
        }
    }
}
