using DecorateCar.Decorators;
using DecorateCar.Interface;
using DecorateCar.Models;
using System;

namespace DecorateCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var decapotable = new Decapotable()
            {
                Annee = 1998,
                Marque = "Ferrari"
            };

            var camion = new Camion()
            {
                Annee = 2010,
                Marque = "Mercedes"
            };

            Console.WriteLine(decapotable.Description()); 

            Voiture decapotableWithSono = new SonoSurpuissante(decapotable)
            {
                Sonorisation = "Sono Yamaha"
            };

            Console.WriteLine(decapotableWithSono.Description());

            Voiture decapotableWithSonoAndMotorisationSurpuissante = new MotorisationSurpuissante(decapotableWithSono)
            {
                Motorisation = "One Logic Team"
            };

            Voiture camionWithMoteurSurpuissante = new MotorisationSurpuissante(camion)
            {
                Motorisation = "Z-TEAM"
            };

            Console.WriteLine(decapotableWithSonoAndMotorisationSurpuissante.Description());
            Console.WriteLine(camionWithMoteurSurpuissante.Description());

            Console.ReadKey();

        }
    }
}
