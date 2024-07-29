using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toybot
{
    public class BotTable
    {
        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < 5 && y >= 0 && y < 5;
        }
    }
}
