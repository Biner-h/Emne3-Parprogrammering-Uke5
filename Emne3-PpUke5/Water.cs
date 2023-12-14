using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne3_PpUke5
{
    internal class Water
    {
        public List<Pokemon> AllPokemons { get; set; }

        public Water(List<Pokemon> list)
        {
            AllPokemons = list;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            AllPokemons.Add(pokemon);
        }

    }
}


