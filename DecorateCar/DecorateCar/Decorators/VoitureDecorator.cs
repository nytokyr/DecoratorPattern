using DecorateCar.Models;

namespace DecorateCar.Decorators
{
    abstract class VoitureDecorator : Voiture
    {
        private  Voiture _wrappee;
        public VoitureDecorator(Voiture wrappee)
        {
            _wrappee = wrappee;
        }
        public override string Description() => _wrappee.Description();
    }
}
