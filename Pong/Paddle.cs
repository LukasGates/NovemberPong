using System;
using Raylib_cs;
using System.Collections.Generic;
namespace Pong
{
    public class Paddle : GameObject
    {
        
        //public float x;
        //public float y;
        //public Rectangle rectangle;
        public KeyboardKey upKey;
        public KeyboardKey downKey;

        Texture2D carTexture;
        Texture2D carTextureL;

        public Paddle(float xStart, float yStart, KeyboardKey up, KeyboardKey down)
        {
            rectangle = new Rectangle(xStart, yStart, 20, 50);
            //x = xStart;
            //y = yStart;
            upKey = up;
            downKey = down;

            gameObjects.Add(this);

            carTexture = Raylib.LoadTexture("car.png");
            carTextureL = Raylib.LoadTexture("carL.png");
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

        //public static void UpdateAll()
        //{
       //     foreach (Paddle p in gameObjects)
         //   {
           //     p.Update();
            // }
        //}
        //Texture2D car = Raylib.LoadTexture("car.png");

        public override void Draw()
        {
            Raylib.DrawTexture(carTexture, (int)rectangle.x, (int)rectangle.y, Color.WHITE);
            Raylib.DrawTexture(carTextureL, (int)rectangle.x, (int)rectangle.y, Color.WHITE);
            //      Raylib.DrawRectangleRec(rectangle, Color.BLACK);
           
        }
        //public static void DrawAll()
        //{
        //    foreach (Paddle p in gameObjects)
        //    {
        //        p.Draw();
        //    }
        //}
    }
}
