using DecorateCar.Interface;

namespace DecorateCar.Models
{
    public class Decapotable : Voiture
    {
        public string MyPropertyOfDecapotable { get; set; }

        public override string Description()
        {
            return $"Decapotable, de MyPropertyOfDecapotable {MyPropertyOfDecapotable}";
        }
    }
}
