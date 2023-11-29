

namespace Emne3_objekterSomiJS
{
    internal class Pikachu
    {
        private int Health;
        private int Level;
        private string Name;

        public Pikachu(int health, int level, string name)
        {
            Health = health;
            Level = level;
            Name = name;
        }

        public void PrintInfo()
        {
            //Console.WriteLine($"Jeg er \"{Name}\". Jeg har \"{Health}\"hp og jeg er level\"{Level}");
            Console.WriteLine($"Jeg heter {Name}. Jeg har {Health}hp og jeg er level {Level}!");
        }
    }
}
