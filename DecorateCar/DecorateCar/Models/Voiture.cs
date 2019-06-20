namespace DecorateCar.Interface
{
    public abstract class Voiture
    {
        public string Marque { get; set; }
        public int Annee { get; set; }

        public abstract string Description();
    }
}
