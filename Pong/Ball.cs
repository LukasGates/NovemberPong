using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System;
using Raylib_cs;
using System.Numerics;
namespace Pong
{
    public class Ball : GameObject
    {
        //public Rectangle rectangle;
        public Vector2 speed = new Vector2(2, 2);

        Texture2D ballTexture;

        public Ball()
        {
            ballTexture = Raylib.LoadTexture("RLball.png");
            rectangle = new Rectangle(390, 290, 20, 20);
            gameObjects.Add(this);
        }
        public override void Update()
        {
            rectangle.x += speed.X;
            rectangle.y += speed.Y;

            if (rectangle.x > 800 - 20 || rectangle.x < 0)
            {
                speed.X = -speed.X;
            }
            if (rectangle.y > 600 - 20 || rectangle.y < 0)
            {
                speed.Y = -speed.Y;
            }

            foreach (GameObject p in GameObject.gameObjects)
            {
                if (p != this)
                {
                    if (Raylib.CheckCollisionRecs(rectangle, p.rectangle))
                    {
                        speed.X = -speed.X;
                    }
                }
            }

        }

        public override void Draw()
        {
            Raylib.DrawTexture(ballTexture, (int)rectangle.x, (int)rectangle.y, Color.WHITE);
        }

        //public void Draw()
        //{
        //     Raylib.DrawRectangleRec(rectangle, Color.BLACK);
        //}
    }
}
