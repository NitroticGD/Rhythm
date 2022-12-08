using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.InteropServices;
//Core libs
using RhythmGame.source.Core;


using RhythmGame.source.States;


namespace RhythmGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private State currentState;
        private State startingState;
        private State nextState;


        //Changes it to queued state or changes to selected state if no state is queued. Will change to selected state even if a state is queued if force is true
        public void ChangeState(State state, bool? force = false)
        {
            if (nextState == null)
            {
                currentState = state;
            } else
            {
                if (force == true)
                {
                    currentState = state;
                }
                else
                {
                    currentState = nextState;
                }
            }
            

        }

        //When a stated is queued the next time a state change is called it switches to the queued state. (can only queue one state)
        public void QueueState(State state)
        {
            nextState = state;
        }
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
        }

        protected override void Initialize()
        {
            startingState = new MainMenuState(Content, _graphics.GraphicsDevice, this);
            currentState = startingState;
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();
            base.Initialize();
        }
 
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
   

        }

        

        protected override void Update(GameTime gameTime)
        {
        
            // TODO: Add your update logic here
            currentState.Update(gameTime);
            currentState.PostUpdate(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            currentState.Draw(gameTime, _spriteBatch);
            base.Draw(gameTime);
        }
    }
}