
namespace Emne3_PpUke5
{
    internal class Spiller
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        
    
        public Spiller(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void showInfo()
        {
            Console.Write($"Name:{Name}");
            Console.Write($" HP:{Health}");
        }
    }
}
