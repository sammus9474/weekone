using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentLib
{
    public class mage : Avatar
    {
        public string wand;
        public string spellBook;

        public override string ToString()
        {
            return string.Format(" {2} Wand: {0} Spell Book: {1}\n", wand, spellBook, base.ToString());
        }
    }
}
