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

            float xPos = 10, yPos = 275;

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BEIGE);

                Raylib.DrawRectangle((int) xPos, (int) yPos, 20, 50, Color.BLACK);

                Raylib.EndDrawing();
            }


            


        }
    }
}
