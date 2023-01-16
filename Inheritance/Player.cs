using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Player : GameCharacter   // add this last part, inheritance!
                                            // you can inherit and inherit
    {
        public int lives = 3;

        public void PlayerOnlyMethod()
        {
            Console.WriteLine("This method is in the Player class, so Enemy can't call it!");
        }

        public Player()
        {
            Console.WriteLine("Player class constructed...");
        }

        public new void ShowStats() // this will override the one in Game Character, so you can include lives!
        {
            base.ShowStats();                       // run the method from GameCharacter
            Console.WriteLine("Lives = " + lives);  // and add something else!
        }
    }
}
