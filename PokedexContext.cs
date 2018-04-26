using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationPokedex
{
    class PokedexContext : DbContext
    {
        public PokedexContext(): base("PokemonBDD")
        {
            Database.SetInitializer<PokedexContext>(new CreateDatabaseIfNotExists<PokedexContext>());
        }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Attaque> Attaques { get; set; }
    }
}
