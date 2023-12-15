using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne3_PpUke5
{
    internal class PokeShop
    {
        public List<Items> AllItems { get; set; }

        public PokeShop(List<Items> list)
        {
            AllItems = list;
        }

        public void AddPokemon(Items items)
        {
            AllItems.Add(items);
        }

        public void ShowShop()
        {
            for (int i = 0; i < AllItems.Count; i++)
            {
                Console.WriteLine($"{i} {AllItems[i].Name}");
            }

            Console.WriteLine("\nSkriv tallet på produktet du vil kjøpe.");
            int input = int.Parse(Console.ReadLine());

            AllItems[input].ShowItem();
        }

    }
}
