using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GC_Demo_APIs.Models;

namespace GC_Demo_APIs.ViewModels
{
    public class PersonPlanetViewModel
    {
        public StarWarsCharacter Person { get; set; }
        public Planet Planet { get; set; }
    }
}
