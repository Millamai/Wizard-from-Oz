using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard_from_Oz
{
    public class TinMan : ICharacter
    {
        public void ThrowMagicMissile()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            Console.WriteLine("Tin Man: I'm healing!");
        }

        public void Die()
        {
            Console.WriteLine("Tin Man: I'm dying!");
        }

        public void ThrowFrostNova()
        {
            throw new NotImplementedException();
        }

        public void RaiseShield()
        {
            Console.WriteLine("Tin Man: I'm raising my metal shield!");
        }

        public void Fight()
        {
            Console.WriteLine("Tin Man: I'm fighting!");
        }

        public void Teleport(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Bash()
        {
            Console.WriteLine("Tin Man: I'm bashing with my axe!");
        }

        public void Cleave()
        {
            Console.WriteLine("Tin Man: I'm cleaving with my axe!");
        }

        public void Slash()
        {
            Console.WriteLine("Tin Man: I'm slashing!");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("Tin Man: I'm using my shiny armor to glare!");
        }
    }
}
