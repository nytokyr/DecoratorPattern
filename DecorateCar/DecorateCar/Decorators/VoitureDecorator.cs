using DecorateCar.Interface;

namespace DecorateCar.Decorators
{
    public class VoitureDecorator : Voiture
    {
        private Voiture _wrappee;
        public VoitureDecorator(Voiture voiture)
        {
            _wrappee = voiture;
        }

        public override string Description() => _wrappee.Description();
    }
}

