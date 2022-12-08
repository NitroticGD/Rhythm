using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class used for all states like MainMenuState, PlayState, CreditsState all that.

namespace RhythmGame.source.Core
{
    public abstract class State
    {
        #region Fields
        protected ContentManager _content;
        protected GraphicsDevice _graphicsDevice;
        protected Game1 _game;

        #endregion

        #region Methods
        public abstract void Draw(GameTime gametime, SpriteBatch spriteBatch);

        public abstract void PostUpdate(GameTime gametime);

        public State(ContentManager content, GraphicsDevice graphicsDevice, Game1 game)
        {
            _content=content;
            _graphicsDevice=graphicsDevice;
            _game=game;
        }

        public abstract void Update(GameTime gametime);
        #endregion

    }
}
