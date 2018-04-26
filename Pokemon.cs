using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationPokedex
{
    class Pokemon
    {
        public int PokemonId { get; set; }
        public int Numero { get; set; }
        public string Nom { get; set; }
        public Attaque Attack { get; set; }
        public int PV { get; set; }
        public int PD { get; set; }
    }
}
