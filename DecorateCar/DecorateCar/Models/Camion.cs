using DecorateCar.Interface;

namespace DecorateCar.Models
{
    public class Camion : Voiture
    {
        public string ChargementMaximal { get; set; }

        public override string Description() => "Je suis un Camion";

    }
}
