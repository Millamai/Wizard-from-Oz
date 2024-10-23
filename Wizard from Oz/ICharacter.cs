using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard_from_Oz
{
    public interface ICharacter
    {
        void ThrowMagicMissile();
        void Heal();
        void Die();
        void ThrowFrostNova();
        void RaiseShield();
        void Fight();
        void Teleport(int x, int y);
        void Bash();
        void Cleave();
        void Slash();
        void ShieldGlare();
    }
}
