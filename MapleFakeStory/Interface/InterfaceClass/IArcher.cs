using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IArcher
    {
        string TrackEnemy(IEnemy KindEnemy);
        void FirstAid(ICharacter Ally);
    }
}
