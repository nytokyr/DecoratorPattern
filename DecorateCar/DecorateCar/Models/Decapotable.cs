using DecorateCar.Interface;

namespace DecorateCar.Models
{
    public class Decapotable : Voiture
    {
        public void OuvrirToit() { }

        public override string Description() => "Je suis une Decapotable";

    }
}
