using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

//Class used for all images on screen
namespace RhythmGame.source.Core
{
    public class Sprite
    {
        private Texture2D _texture;
        public Vector2 position;
        public Vector2 scale = new Vector2(1, 1);
        public Texture2D sprite;

        public Sprite(Texture2D texture, int X = 0, int Y = 0)
        {
            _texture = texture;
            position = new Vector2(X, Y);
            sprite = texture;
        }

        public void setScale(float scaleX, float scaleY)
        {
            scale = new Vector2(scaleX, scaleY);
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch) 
        {
            if (_texture != null) 
            {
                if (scale.X == 1 && scale.Y == 1)
                {
                    spriteBatch.Draw(sprite, position, Color.White);
                } else
                {
                    spriteBatch.Draw(sprite, position, new Rectangle((int)position.X, (int)position.Y, _texture.Width, _texture.Height), Color.White, 0, position, scale, 0, 0f);
                }
                
            }
        }
    }
}
