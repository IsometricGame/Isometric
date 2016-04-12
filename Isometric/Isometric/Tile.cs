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
    class Tile
    {
        public static Texture2D TileSetTexture;

        public static Rectangle GetSourceRectangle(int tileIndex)
        {
            return new Rectangle(tileIndex * 32, 0, 32, 32);
        }
    }
}
