using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard_from_Oz
{
    public class Lion : ICharacter
    {
        public void ThrowMagicMissile()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            Console.WriteLine("Lion: I'm healing!");
        }

        public void Die()
        {
            Console.WriteLine("Lion: I'm dying!");
        }

        public void ThrowFrostNova()
        {
            throw new NotImplementedException();
        }

        public void RaiseShield()
        {
            throw new NotImplementedException();
        }

        public void Fight()
        {
            Console.WriteLine("Lion: I'm fighting!");
        }

        public void Teleport(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Bash()
        {
            Console.WriteLine("Lion: I'm bashing someone!");
        }

        public void Cleave()
        {
            Console.WriteLine("Lion: I'm cleaving someone!");
        }

        public void Slash()
        {
            Console.WriteLine("Lion: I'm slashing at my foes!");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("Lion: I'm glaring fiercely!");
        }
    }
}
