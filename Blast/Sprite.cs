using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Blast
{
    public class Sprite
    {
        public Sprite(Texture2D texture)
        {
            if (texture == null)
                throw new Exception("Texture was not expected to be null.");

            Texture = texture;
            Scale = Vector2.One;
            Size = new Vector2(Texture.Width, Texture.Height);
            Color = Color.White;
            Rotation = 0f;
        }

        public Sprite(Texture2D texture, Vector2 scale, Color color, float rotation)
        {
            if (texture == null)
                throw new Exception("Texture was not expected to be null.");

            Texture = texture;
            Scale = scale;
            Size = new Vector2(Texture.Width, Texture.Height);
            Color = color;
            Rotation = rotation;
        }

        public Texture2D Texture { get; private set; }
        
        public Vector2 Size { get; private set; }

        public Vector2 Scale { get; set; }

        public Color Color { get; set; }

        public float Rotation { get; set; }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(
                Texture,
                position,
                null,
                Color,
                0f,
                new Vector2(Size.X / 2, Size.Y / 2),
                Scale,
                SpriteEffects.None,
                0f);
        }
    }
}
