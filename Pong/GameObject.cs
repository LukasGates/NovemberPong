using System;
using Raylib_cs;
using System.Collections.Generic;
namespace Pong
{
    public class GameObject
    {
        public Rectangle rectangle;

        public static List<GameObject> gameObjects = new List<GameObject>();

        public virtual void Update()
        {

        }

        public static void UpdateAll()
        {
            foreach (GameObject g in gameObjects)
            {
                g.Update();
            }
        }

        public virtual void Draw()
        {
            Raylib.DrawRectangleRec(rectangle, Color.BLACK);
            //Raylib.DrawTextureRec(car, Color.WHITE);
        }
        public static void DrawAll()
        {
            foreach (GameObject g in gameObjects)
            {
                g.Draw();
            }
        }
    }
}


