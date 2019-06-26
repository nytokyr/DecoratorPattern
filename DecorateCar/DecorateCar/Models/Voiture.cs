using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateCar.Models
{
    abstract class Voiture
    {
        protected string Id { get; set; }
        protected Voiture(string id)
        {
            Id = Id;
        }
        protected abstract string Description();
    }
}
