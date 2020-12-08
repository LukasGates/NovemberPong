using System;
using Raylib_cs;

namespace Pong
{
    public class GameObject
    {
        public Rectangle rectangle;

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            Raylib.DrawRectangleRec(rectangle, Color.BLACK);
            //Raylib.DrawTextureRec(car, Color.WHITE);
        }
    }
}


