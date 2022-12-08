using InputStateManager;
using Mouse = InputStateManager.Inputs.Mouse;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RhythmGame.source.Core;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace RhythmGame.source.States
{
    public class MainMenuState : State
    {
        private readonly InputManager input = new InputManager();
        private List<string> buttons; //List containing every button to appear
        private Sprite titlebg;
        private Sprite storymodetex;
        private Sprite freeplaytex;
        private Sprite optionstex;
        private Sprite creditstex;
        private Button storymode;
        private Button freeplay;
        private Button credits;
        private Button options;


        


        public MainMenuState(ContentManager content, GraphicsDevice graphicsDevice, Game1 game) : base(content, graphicsDevice, game)
        {


            titlebg = new Sprite(_content.Load<Texture2D>("titlebg"), 0, 0);
            storymodetex = new Sprite(_content.Load<Texture2D>("storymode"), 0, 0);
            freeplaytex = new Sprite(_content.Load<Texture2D>("freeplay"), 0, 60);
            creditstex = new Sprite(_content.Load<Texture2D>("credits"), 0, 120);
            optionstex = new Sprite(_content.Load<Texture2D>("options"), 0, 180);
            //Clickable buttons
            storymode = new Button(storymodetex.sprite, _content.Load<SpriteFont>("fonts/dfont"), _content.Load<Texture2D>("storymodeselected"));
            
            buttons = new List<string>()
            {
                "storymode",
                "freeplay",
                "credits",
                "options"
            };




        }

        private void Storymode(object sender, EventArgs e)
        {
            _game.ChangeState(new StorymodeState(_content, _graphicsDevice, _game), false);
        }

 
        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            //Draws all buttons to the screen
            spriteBatch.Begin();
            /*
            foreach(var button in buttons) {
                var i = 0;
                if (i == 0)
                {
                    var btnsprite = new Sprite(_content.Load<Texture2D>(button), 0, 0);
                    spriteBatch.Draw(btnsprite.sprite, btnsprite.position, new Rectangle(0, 0, btnsprite.sprite.Width, btnsprite.sprite.Height), Color.White);
                } else
                {
                    if (i == 4) { i = 5; }
                    var y = (i + 1) * 100;
                    
                    var btnsprite = new Sprite(_content.Load<Texture2D>(button), 0, y);
                    spriteBatch.Draw(btnsprite.sprite, btnsprite.position, new Rectangle(0, 0, btnsprite.sprite.Width, btnsprite.sprite.Height), Color.White);
                }
                i++;
               
            }
            */

            titlebg.Draw(spriteBatch);
            storymode.Draw(gametime, spriteBatch);
            spriteBatch.End();
        }




        public override void PostUpdate(GameTime gametime)
        {
            
        }

        public override void Update(GameTime gametime)
        {

        }
    }
}
