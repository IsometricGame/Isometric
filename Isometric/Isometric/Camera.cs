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
    static class Camera
    {
        public static TileMap GameMap = new TileMap();
        static public Vector2 Position = Vector2.Zero;

        public static void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.Left))
            {
                Camera.Position.X = MathHelper.Clamp(Camera.Position.X - 2, 0, (GameMap.MapDimensions.X - GameMap.RenderDistanceX) * 32);
            }

            if (ks.IsKeyDown(Keys.Right))
            {
                Camera.Position.X = MathHelper.Clamp(Camera.Position.X + 2, 0, (GameMap.MapDimensions.X - GameMap.RenderDistanceX) * 32);
            }

            if (ks.IsKeyDown(Keys.Up))
            {
                Camera.Position.Y = MathHelper.Clamp(Camera.Position.Y - 2, 0, (GameMap.MapDimensions.Y - GameMap.RenderDistanceY) * 32);
            }

            if (ks.IsKeyDown(Keys.Down))
            {
                Camera.Position.Y = MathHelper.Clamp(Camera.Position.Y + 2, 0, (GameMap.MapDimensions.Y - GameMap.RenderDistanceY) * 32);
            }
        }
    }
}
