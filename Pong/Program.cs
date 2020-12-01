using System.Collections.Generic;
using System;
using Raylib_cs;
namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make spicy pong game.
            Raylib.InitWindow(800, 600, "Pong");
            Raylib.SetTargetFPS(60);

            

            Paddle leftPaddle = new Paddle(10, 275, KeyboardKey.KEY_W, KeyboardKey.KEY_S);
            Paddle rightPaddle = new Paddle(770, 275, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN);


            Ball ball = new Ball();

            while (!Raylib.WindowShouldClose())
            {
                Paddle.UpdateAll();
            
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GREEN);

                Paddle.DrawAll();
                ball.Update();
                ball.Draw();
                Raylib.EndDrawing();
            }


            


        }
    }
}
