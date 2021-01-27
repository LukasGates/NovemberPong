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

        Texture2D car;
       

        //Start position för bilar/paddles
        public Paddle(float xStart, float yStart, KeyboardKey up, KeyboardKey down, Texture2D carTexture)
        {
            this.car = carTexture;
            rectangle = new Rectangle(xStart, yStart, 20, 50);
            //x = xStart;
            //y = yStart;
            upKey = up;
            downKey = down;
        

            gameObjects.Add(this);

            
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

    

        public override void Draw()
        {
            Raylib.DrawTexture(car, (int)rectangle.x, (int)rectangle.y, Color.WHITE);
            //Raylib.DrawTexture(carTextureL, (int)rectangle.x, (int)rectangle.y, Color.WHITE);
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
