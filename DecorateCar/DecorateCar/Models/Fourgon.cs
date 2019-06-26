namespace DecorateCar.Models
{
    class Fourgon : Voiture
    {
        public Fourgon(string id)
        {
            Id = id;
        }

        public override string Description() => $"Je suis un fourgon, numero {Id}";
    }
}
