using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ships
    {
        public string name;
        public int shipSize;

        public Ships(string name, int shipSize)
        {
            this.name = name;
            this.shipSize = shipSize;
        }
    }
}
