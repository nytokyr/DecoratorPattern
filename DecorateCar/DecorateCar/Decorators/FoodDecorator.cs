using DecorateCar.Models;

namespace DecorateCar.Decorators
{
    class FoodDecorator : VoitureDecorator
    {
        public FoodDecorator(Voiture wrappee) : base(wrappee)
        {
        }
        public override string Description() => $"{base.Description()}, je peux vendre de la bouffe ";
    }
}

