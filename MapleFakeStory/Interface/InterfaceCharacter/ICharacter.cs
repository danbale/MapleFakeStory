using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICharacter
    {
        string Attack(IEnemy Enemy);
        void Move();
        int Sleep();
        ICharacter UpgradeClass(ICharacter Character);
    }
}
