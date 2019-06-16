using DecorateCar.Interface;

namespace DecorateCar.Models
{
    public class Camion : Voiture
    {
        public string PropertyTruck { get; set; }

        public override string Description => $"{base.Description}, de PropertyTruck {PropertyTruck}";
    }
}
