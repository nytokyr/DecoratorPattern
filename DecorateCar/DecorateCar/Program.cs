using DecorateCar.Decorators;
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
                Marque = "Ferrari",
                MyPropertyOfDecapotable = "cheveux aux vents"
            };

            var camion = new Camion()
            {
                Annee = 2010,
                Marque = "Mercedes",
                PropertyTruck = "transporte des charges lourdes"
            };

            Console.WriteLine(decapotable.Description());

            var decapotableWithSono = new SonoSurpuissante(decapotable)
            {
                Sonorisation = "Sono Yamaha"
            };

            Console.WriteLine(decapotableWithSono.Description());

            var decapotableWithSonoAndMotorisationSurpuissante = new MotorisationSurpuissante(decapotableWithSono)
            {
                Motorisation = "moteur reprogrammé par One Logic"
            };

            Console.WriteLine(decapotableWithSonoAndMotorisationSurpuissante.Description());

            Console.ReadKey();

        }
    }
}
