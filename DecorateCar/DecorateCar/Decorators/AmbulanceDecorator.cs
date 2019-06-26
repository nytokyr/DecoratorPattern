using DecorateCar.Models;

namespace DecorateCar.Decorators
{
    class AmbulanceDecorator : VoitureDecorator
    {
        public AmbulanceDecorator(Voiture wrappee) : base(wrappee)
        {
        }
        public override string Description() => $"{base.Wrappee.Description()}, j'ai des kits médicaux";
    }
}
