using System;
using System.Collections.Generic;
using System.Text;

namespace Sea_battle
{
    public class Field
    {
        private byte[,] cells = new byte[10, 10];
        public byte GetCellValley(byte x, byte y)
        {
            return cells[x,y];
        }
        public bool SetCellValley()
    }

}
