using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world! I'm learning about inheritance!");
            Console.ReadKey(true);

            // instantiate player and enemy classes
            Console.WriteLine();
            Player player = new Player();
            Enemy enemy = new Enemy();

            Console.WriteLine();
            Console.WriteLine("Player:");
            player.ShowStats();
            player.TakeDamage(15);
            player.ShowStats();

            // player.lives can be used because 'lives' exists within player
            // but not in enemy or in GameCharacter

            player.PlayerOnlyMethod();
            player.Heal(5);
            player.ShowStats();

            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine("Enemy:");
            enemy.ShowStats();
            enemy.TakeDamage(25);
            enemy.ShowStats();
            enemy.Heal(10);
            enemy.ShowStats();

            Console.ReadKey(true);
        }
    }
}
