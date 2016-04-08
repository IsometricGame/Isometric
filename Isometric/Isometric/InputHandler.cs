using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Input;

namespace Isometric
{
    static class InputHandler
    {
        private static KeyboardState currentKey_, oldKey_;

        public static void Update()
        {
            oldKey_ = currentKey_;

            currentKey_ = Keyboard.GetState();
        }

        /// <summary>
        /// Checks if a key is pressed
        /// </summary>
        /// <param name="key">The key to match against</param>
        /// <param name="onceOnly">A bool telling if the press is allowed only if the key was not held down the loop before</param>
        /// <returns>True or false based on params</returns>
        public static bool IsPressed(Keys key, bool onceOnly = false)
        {
            if (onceOnly)
            {
                if (currentKey_.IsKeyDown(key) && currentKey_ != oldKey_) //Checks so that the key was not held down previous loop
                    return true;
            }
            else if(!onceOnly)
            {
                if (currentKey_.IsKeyDown(key))
                    return true;
            }

            return false;
        }

    }
}
