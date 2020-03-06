using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.Character.CharacterClass.Range
{
    public class Archer : ICharacter
    {
        // Character methods

        public string Attack(IEnemy Enemy)
        {
            return "Archer ATTACK!";
        }

        public void Move()
        {
            Console.WriteLine("Move Archer!");
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

        // Archer Methods


    }
}
