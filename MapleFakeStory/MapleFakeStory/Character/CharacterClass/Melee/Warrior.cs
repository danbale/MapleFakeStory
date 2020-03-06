using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.Character
{
    public class Warrior : ICharacter
    {
        
        // Character Methods

        public string Attack(IEnemy Enemy)
        {
            return "Warrior ATTACK!";
        }

        public void Move()
        {
            Console.WriteLine("Move like a Warrior!");
        }

        public int Sleep()
        {
            Console.WriteLine("sleeping zzzzz");
            return 1;
        }

        public ICharacter UpgradeClass(ICharacter Character)
        {
            // validation logic
            return Character;
        }

    }

    
}
