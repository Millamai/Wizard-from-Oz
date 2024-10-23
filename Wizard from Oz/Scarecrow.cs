using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard_from_Oz
{
    public class Scarecrow : ICharacter
    {
        public void ThrowMagicMissile()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            Console.WriteLine("Scarecrow: I'm healing!");
        }

        public void Die()
        {
            Console.WriteLine("Scarecrow: I'm dying!");
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
            Console.WriteLine("Scarecrow: I'm fighting!");
        }

        public void Teleport(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Bash()
        {
            Console.WriteLine("Scarecrow: I'm bashing someone with my stick!");
        }

        public void Cleave()
        {
            Console.WriteLine("Scarecrow: I'm cleaving through the weeds!");
        }

        public void Slash()
        {
            Console.WriteLine("Scarecrow: I'm slashing at the crows!");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("Scarecrow: I'm glaring at the enemies with my empty gaze!");
        }
    }
}
