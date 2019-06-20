using DecorateCar.Interface;

namespace DecorateCar.Decorators
{
    public class MotorisationSurpuissante : VoitureDecorator
    {
        public string Motorisation { get; set; }
        public MotorisationSurpuissante(Voiture voiture) : base(voiture)
        {

        }
        public override string Description() => $"{base.Description()}, powered-by {Motorisation}";
       

    }
}
