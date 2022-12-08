using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RhythmGame.source.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmGame.source.States
{
    public class StorymodeState : State
    {
        private Sprite titlebg;
        public StorymodeState(ContentManager content, GraphicsDevice graphicsDevice, Game1 game) : base(content, graphicsDevice, game)
        {
            titlebg = new Sprite(_content.Load<Texture2D>("titlebg"), 0, 0);
        }

        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            titlebg.Draw(spriteBatch);
        }

        public override void PostUpdate(GameTime gametime)
        {
            
        }

        public override void Update(GameTime gametime)
        {
            
        }
    }
}
