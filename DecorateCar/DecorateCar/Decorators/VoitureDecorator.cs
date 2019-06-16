using DecorateCar.Interface;

namespace DecorateCar.Decorators
{
    public class VoitureDecorator : Voiture
    {
        public VoitureDecorator(Voiture voiture)
        {
            _Wrappee = voiture;
        }
        private Voiture _Wrappee { get; set; }


        public override string Description()
        {
            return _Wrappee.Description();
        }
    }
}
