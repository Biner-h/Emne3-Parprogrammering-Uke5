using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne3_PpUke5
{
    internal class Grass
    {
        public List<Pokemon> AllPokemons { get; set; }

        public Grass(List<Pokemon> list)
        {
            AllPokemons = list;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            AllPokemons.Add(pokemon);
        }

        public void GetGrassPokemon()
        {
            for (int i = 0; i < AllPokemons.Count; i++)
            {
                Console.WriteLine($"{i} {AllPokemons[i].Name}");
            }

            Console.WriteLine("\nSkriv tallet på pokemonen du vil fange.");
            int input = int.Parse(Console.ReadLine());

            AllPokemons[input].ShowPokemon();
        }
    }
}

