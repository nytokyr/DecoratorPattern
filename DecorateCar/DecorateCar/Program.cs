using DecorateCar.Decorators;
using DecorateCar.Models;
using System;

namespace DecorateCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var camion = new Camion("MH-01");
            Console.WriteLine(camion.Description());//achat            

            var camionAmbulance = new AmbulanceDecorator(camion);
            Console.WriteLine(camionAmbulance.Description());

            var camionAmbulanceWithFood = new FoodDecorator(camionAmbulance);
            Console.WriteLine(camionAmbulanceWithFood.Description());




            Console.ReadKey();

        }
    }
}
