﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FinalProject.Entities
{
    internal class Enemy : BasicEntity
    {
        private int leftBounds;
        private int rightBounds;

        private bool isMovingLeft = true;

        public Enemy(int speed) : base(new Vector2(Game1.ScreenWidth / 5 * 4, Game1.ScreenHeight - 300), speed)
        {
            leftBounds = Game1.ScreenWidth / 5 * 3;
            rightBounds = Game1.ScreenWidth / 5 * 4;
        }

        public void Move()
        {
            if (isMovingLeft)
            {
                if (Position.X <= leftBounds)
                {
                    Position = new Vector2(leftBounds, Position.Y);
                    isMovingLeft = false;
                }
                else
                {
                    Position = new Vector2(Position.X - Speed, Position.Y);
                }
            }
            else
            {
                if (Position.X >= rightBounds)
                {
                    Position = new Vector2(rightBounds, Position.Y);
                    isMovingLeft = true;
                }
                else
                {
                    Position = new Vector2(Position.X + Speed, Position.Y);
                }
            }
        }

        public void UpdateBounds(int delta)
        {
            Position = new Vector2(Position.X - delta, Position.Y);
            leftBounds -= delta;
            rightBounds -= delta;
        }
    }
}
