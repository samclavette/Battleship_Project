using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        public string name;
        List<Ships> shipList;
        int[,] gameboard = new int[20, 20];
    }
}
