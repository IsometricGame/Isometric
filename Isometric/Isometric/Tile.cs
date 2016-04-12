using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Altharius_Game_Engine
{
    //TODO: Add types 
    enum TileType
    {
        grass = 0,
        wall = 1
    }

    class Tile
    {
        public static Texture2D TileSetTexture;

        public Tile(int tileNumber)
        {
            if(tileNumber == (int)TileType.grass)
            {

            }
            else if(tileNumber == (int)TileType.wall)
            {

            }
        }

        public static Rectangle GetSourceRectangle(int tileIndex)
        {
            return new Rectangle(tileIndex * 32, 0, 32, 32);
        }
    }
}
