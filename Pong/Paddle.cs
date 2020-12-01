using System;
using Raylib_cs;
using System.Collections.Generic;
namespace Pong
{
    public class Paddle
    {
        static List<Paddle> paddles = new List<Paddle>();
        public float x;
        public float y;

        public KeyboardKey upKey;
        public KeyboardKey downKey;


        public Paddle(float xStart, float yStart, KeyboardKey up, KeyboardKey down)
        {
            x = xStart;
            y = yStart;
            upKey = up;
            downKey = down;

            paddles.Add(this);
        }

        public void Update()
        {
            if (Raylib.IsKeyDown(upKey))
            {
                y -= 5f;
            }
            if (Raylib.IsKeyDown(downKey))
            {
                y += 5f;
            }
        }

        public static void UpdateAll()
        {
            foreach (Paddle p in paddles)
                {
                    p.Update();
                }
        }
        Texture2D car = Raylib.LoadTexture("car.png");
        public void Draw()
        {
            //Raylib.DrawRectangle((int) x, (int) y, 20, 50, Color.BLACK);
            Raylib.DrawTexture(car, (int) x, (int) y, Color.WHITE);
        }
        public static void DrawAll()
        {
            foreach (Paddle p in paddles)
                {
                    p.Draw();
                }
        }
    }
}
