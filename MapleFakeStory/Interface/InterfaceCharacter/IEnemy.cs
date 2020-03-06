using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IEnemy
    {
        bool Defense();
        string Attack(ICharacter character);
    }
}
