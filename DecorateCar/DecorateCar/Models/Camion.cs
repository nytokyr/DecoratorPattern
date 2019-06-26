namespace DecorateCar.Models
{
    class Camion : Voiture
    {
        public Camion(string id)
        {
            Id = id;
        }

        public override string Description() => $"Je suis un camion, numero {Id}";
    }
}
