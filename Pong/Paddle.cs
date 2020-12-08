using System;
using Raylib_cs;
using System.Collections.Generic;
namespace Pong
{
    public class Paddle : GameObject
    {
        public static List<Paddle> paddles = new List<Paddle>();
        //public float x;
        //public float y;
        //public Rectangle rectangle;
        public KeyboardKey upKey;
        public KeyboardKey downKey;

        public Paddle(float xStart, float yStart, KeyboardKey up, KeyboardKey down)
        {
            rectangle = new Rectangle(xStart, yStart, 20, 50);
            //x = xStart;
            //y = yStart;
            upKey = up;
            downKey = down;

            paddles.Add(this);
        }

        public override void Update()
        {
            if (Raylib.IsKeyDown(upKey))
            {
                rectangle.y -= 5f;
            }
            if (Raylib.IsKeyDown(downKey))
            {
                rectangle.y += 5f;
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
        //public void Draw()
        // {
        //      Raylib.DrawRectangleRec(rectangle, Color.BLACK);
        //      Raylib.DrawTextureRec(car, Color.WHITE);
        //  }
        public static void DrawAll()
        {
            foreach (Paddle p in paddles)
            {
                p.Draw();
            }
        }
    }
}
