using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Enemy : GameCharacter // add this last part, inheritance!
                                         // you can inherit and inherit! try making Orc class so "Orc : Enemy"
    {

        public Enemy()
        {
            Console.WriteLine("Enemy class constructed...");
        }
    }
}
