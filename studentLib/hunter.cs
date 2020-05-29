using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentLib
{
    public class hunter : Avatar
    {

        public string bow;
        public string quiver;

        public override string ToString()
        {
            return string.Format(" {2} Bow: {0} Quiver: {1}\n",bow,quiver, base.ToString());
        }


    }
}
