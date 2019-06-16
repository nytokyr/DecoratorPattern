using DecorateCar.Interface;

namespace DecorateCar.Decorators
{
    public class MotorisationSurpuissante : VoitureDecorator
    {
        private Voiture wrappee;

        public MotorisationSurpuissante(Voiture voiture)
        {
            wrappee = voiture;
        }
        public string Motorisation { get; set; }
        public override string Description => $"{wrappee.Description}, powered-by {Motorisation}";
    }
}
