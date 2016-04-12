using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altharius_Game_Engine
{
    public class MapCell
    {
        public int TileID { get; set; }

        public MapCell(int tileID)
        {
            TileID = tileID;
        }
    }
}
