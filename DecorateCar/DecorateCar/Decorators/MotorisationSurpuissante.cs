using DecorateCar.Interface;

namespace DecorateCar.Decorators
{
    public class MotorisationSurpuissante : VoitureDecorator
    {
        public string Motorisation { get; set; }
        public override string Description() => $"{base.Description()}, powered-by {Motorisation}";
        public MotorisationSurpuissante(Voiture voiture) : base(voiture)
        {

        }

    }
}
