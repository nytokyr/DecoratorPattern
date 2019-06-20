using DecorateCar.Interface;

namespace DecorateCar.Models
{
    public class Decapotable : Voiture
    {
        public string MyPropertyOfDecapotable { get; set; }

        public override string Description()=> $"Decapotable, de MyPropertyOfDecapotable {MyPropertyOfDecapotable}";
        
    }
}
