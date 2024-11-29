﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FinalProject.Entities
{
    internal abstract class BasicEntity
    {
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }
        public Rectangle Hitbox { get; set; }
        public int Speed { get; set; }

        public BasicEntity(Vector2 position, int speed)
        {
            Position = position;
            Texture = null;
            Hitbox = new Rectangle();
            Speed = speed;
        }
    }
}