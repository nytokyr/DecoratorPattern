namespace DecorateCar.Models
{
    class Fourgon : Voiture
    {
        public Fourgon(string id) : base(id)
        {
        }

        protected override string Description() => $"Je suis un fourgon, numero {Id}";
    }
}
