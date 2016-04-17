using System;
using SwinGameSDK;
<<<<<<< HEAD
// using SwinGameSDK.SwinGame; // requires mcs version 4+, 
=======
using SwinGameSDK.SwinGame; // requires mcs version 4+, 
>>>>>>> Converted-Code-C#

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
            OpenGraphicsWindow("GameMain", 800, 600);
            ShowSwinGameSplashScreen();
<<<<<<< HEAD

=======
            
>>>>>>> Converted-Code-C#
            //Run the game loop
            while(false == WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                ProcessEvents();
<<<<<<< HEAD

                //Clear the screen and draw the framerate
                ClearScreen(Color.White);
                DrawFramerate(0,0);

=======
                
                //Clear the screen and draw the framerate
                ClearScreen(Color.White);
                DrawFramerate(0,0);
                
>>>>>>> Converted-Code-C#
                //Draw onto the screen
                RefreshScreen(60);
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> Converted-Code-C#
