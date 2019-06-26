using DecorateCar.Models;

namespace DecorateCar.Decorators
{
    abstract class VoitureDecorator : Voiture
    {
        protected Voiture Wrappee;
        public VoitureDecorator(Voiture wrappee)
        {
            Wrappee = wrappee;
        }
        public override string Description() => Wrappee.Description();
    }
}
