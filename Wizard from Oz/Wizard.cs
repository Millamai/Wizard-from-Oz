using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard_from_Oz
{
    public class Wizard : ICharacter
    {
        public void ThrowMagicMissile()
        {
            Console.WriteLine("Wizard: I'm throwing a magic missile!");
        }

        public void Heal()
        {
            Console.WriteLine("Wizard: I'm healing!");
        }

        public void Die()
        {
            Console.WriteLine("Wizard: I'm dying!");
        }

        public void ThrowFrostNova()
        {
            Console.WriteLine("Wizard: I'm throwing my frost nova!");
        }

        public void RaiseShield()
        {
            throw new NotImplementedException();
        }

        public void Fight()
        {
            Console.WriteLine("Wizard: I'm fighting!");
        }

        public void Teleport(int x, int y)
        {
            Console.WriteLine($"Wizard: I'm teleporting to {x}, {y}!");
        }

        public void Bash()
        {
            throw new NotImplementedException();
        }

        public void Cleave()
        {
            throw new NotImplementedException();
        }

        public void Slash()
        {
            throw new NotImplementedException();
        }

        public void ShieldGlare()
        {
            throw new NotImplementedException();
        }
    }
}
