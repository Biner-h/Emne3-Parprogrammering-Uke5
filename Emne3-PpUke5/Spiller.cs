
namespace Emne3_PpUke5
{
    internal class Spiller
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public List<Pokemon> pokemons { get; set; }
    
        public Spiller(string name, int health)
        {
            Name = name;
            Health = health;
            

        }

        public void showInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}\n");
        }
    }
}
