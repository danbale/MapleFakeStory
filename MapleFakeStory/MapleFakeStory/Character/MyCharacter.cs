using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleFakeStory.Character
{
    public class MyCharacter : ICharacter
    {

        ICharacter characterClass;
        private string name;
        private string age;
        private string gender;
        private Faction faction;

        public MyCharacter(ICharacter _characterClass, string _name, string _age, Faction _faction, string _gender)
        {
            this.characterClass = _characterClass;
            this.name = _name;
            this.age = _age;
            this.faction = _faction;
            this.gender = _gender;
        }

        public string Attack(IEnemy Enemy)
        {
            return this.characterClass.Attack(Enemy);
        }
        public void Move()
        {
            this.characterClass.Move();
        }

        public int Sleep()
        {
            return this.characterClass.Sleep();
        }

        public ICharacter UpgradeClass(ICharacter character)
        {
            this.characterClass = this.characterClass.UpgradeClass(character);
            return this.characterClass;
        }


    }
}
