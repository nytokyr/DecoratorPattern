using DecorateCar.Interface;

namespace DecorateCar.Decorators
{
    public class SonoSurpuissante : VoitureDecorator
    {
        public SonoSurpuissante(Voiture voiture) : base(voiture)
        {
        }

        public string Sonorisation { get; set; }

        public override string Description() => $"{base.Description()} , kit sono {Sonorisation}";
    }
}
