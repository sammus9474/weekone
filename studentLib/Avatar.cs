using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentLib
{
    public class Avatar
    {

        public string name;
        public string race;

        public override string ToString()
        {
            return string.Format("Name: {0} Race : {1}\n", name, race);
        }

    }
}
