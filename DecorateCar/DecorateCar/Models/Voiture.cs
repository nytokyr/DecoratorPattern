namespace DecorateCar.Interface
{
    public class Voiture
    {
        public string Marque { get; set; }
        public int Annee { get; set; }

        public virtual string Description
        {
            get
            {
                return $"Voiture de la marque {Marque} sortie en {Annee}";
            }
        }
    }
}
