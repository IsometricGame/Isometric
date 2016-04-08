using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Input;

namespace Isometric.Obsoletes
{
    [Obsolete]
    class InputHandler : Subject
    {
        private KeyboardState currentKey_, oldKey_;

        public void Update()
        {
            oldKey_ = currentKey_;

            currentKey_ = Keyboard.GetState();

            KeyChecks(); //Runs the key check for the specified keys
            
        }

        private void KeyChecks()
        {
            //Run all ifs for if input is taken

            if(currentKey_ != oldKey_)
            {
                //Run all for if key is pressed once

                if (currentKey_.IsKeyDown(Keys.Enter))
                    Notify(Events.KEY_PRESSED_ENTER);
            }

            //Run all for if key is held down

        }
    }
}
