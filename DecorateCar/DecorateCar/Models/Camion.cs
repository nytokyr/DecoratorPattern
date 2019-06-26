using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateCar.Models
{
    class Camion : Voiture
    {
        public Camion(string id) 
        {
            Id = id;
        }

        protected override string Description() => $"Je suis un camion, numero {Id}";
    }
}
