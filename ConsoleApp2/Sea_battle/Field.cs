using System;
using System.Collections.Generic;
using System.Text;

namespace Sea_battle
{
    public class Field
    {
        private byte[,] cells;
        public byte GetCellValley(byte x, byte y)
        {
            return cells[x,y];
        }
        public bool SetCellValley()
        {

        }
        public Field(int sizex, int sizey)
        {
            cells = new byte[sizex, sizey];
        }
        public Field(int sizex)
        {
            cells = new byte[sizex, sizex];
        }


    }

}
