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
        public bool SetCellValley(byte x, byte y, byte valley)
        {
            if (cells[x,y] != 0)
            {
                return false;
            }
            cells[x, y] = valley;
            return true;
        }
        public bool CrashCell(byte x, byte y)
        {
            if (cells[x, y] != 0)
            {
                return true;
            }
            return false;
        }
        public Field(int sizex, int sizey)
        {
            cells = new byte[sizex, sizey];
        }
        public Field(int sizex):this(sizex, sizex)
        {
            
        }
        public Field(): this(10,10)
        {

        }

    }

}
