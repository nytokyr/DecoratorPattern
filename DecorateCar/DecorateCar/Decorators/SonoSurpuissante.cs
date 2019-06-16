using DecorateCar.Interface;

namespace DecorateCar.Decorators
{
    public class SonoSurpuissante : VoitureDecorator
    {
        private Voiture wrappee;

        public SonoSurpuissante(Voiture voiture)
        {
            this.wrappee = voiture;
        }

        public string Sonorisation { get; set; }

        public override string Description => $"{wrappee.Description} , kit sono {Sonorisation}";
    }
}
