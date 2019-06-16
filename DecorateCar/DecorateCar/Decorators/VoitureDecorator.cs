using DecorateCar.Interface;

namespace DecorateCar.Decorators
{
    public class VoitureDecorator : Voiture
    {
        Voiture _voiture;
        public override string Description => base.Description;
    }
}
