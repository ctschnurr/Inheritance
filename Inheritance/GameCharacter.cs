using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class GameCharacter // we can add the 'abstract' part to tell the program we don't want to be able to instantiate them as objects/variables
    {

        public int health = 100;
        public int damage = 5;

        public void TakeDamage(int hp)
        {
            Console.WriteLine("About to take " + hp + " damage...");
            health -= hp; // health = health - hp
            if (health < 0) health = 0;
        }

        public GameCharacter()
        {
            Console.WriteLine("Game Character class constructed...");
        }

        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine("health = " + health);
            Console.WriteLine("damage = " + damage);

        }

        public void Heal(int hp)
        {
            health += hp;
            if (health > 100) health = 100;
            Console.WriteLine("About to heal " + hp + " health...");
        }

    }
}
