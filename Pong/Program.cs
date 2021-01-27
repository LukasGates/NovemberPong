using System.Collections.Generic;
using System;
using Raylib_cs;

namespace Pong
{
    class Program
    {

        enum GameScreens 
        {
            Start,
            Game,
            GameOver
        }
        static void Main(string[] args)
        {
            //pong game med Rocket League bilar + boll.
            Raylib.InitWindow(1000, 600, "Pong");
            Raylib.SetTargetFPS(60);


            //Bil texturer
            Texture2D carTexture = Raylib.LoadTexture("car.png");

            Texture2D carTextureL = Raylib.LoadTexture("carL.png");

            GameObject leftPaddle = new Paddle(30, 275, KeyboardKey.KEY_W, KeyboardKey.KEY_S, carTextureL);
            GameObject rightPaddle = new Paddle(850, 275, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN, carTexture);
            
            Ball ball = new Ball();


            //start
            GameScreens screen = GameScreens.Start;

            while (!Raylib.WindowShouldClose())
            {
                if (screen == GameScreens.Start)
                {
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        screen = GameScreens.Game;
                    }
                }
                else if (screen == GameScreens.Game)
                {
                    GameObject.UpdateAll();
                }
                
                
                Raylib.BeginDrawing();
                

                 if (screen == GameScreens.Start)
                {
                    Texture2D screenTexture;
                    screenTexture = Raylib.LoadTexture("Sscreen.png");
                    Raylib.DrawTexture(screenTexture, (int)165, (int)1, Color.WHITE);
                    Raylib.DrawText("Press ENTER to start", 173, 545, 58, Color.ORANGE);
                    Raylib.ClearBackground(Color.BLACK);
                }
                else if (screen == GameScreens.Game)
                {
                    Raylib.ClearBackground(Color.GREEN);
                    GameObject.DrawAll();
                }

                
                //ball.Update();
                //ball.Draw();
                Raylib.EndDrawing();
            }


            


        }
    }
}
