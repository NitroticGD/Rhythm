using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputStateManager;
using IMouse = InputStateManager.Inputs.Mouse;

namespace RhythmGame.source.Core
{
    public class Button : Component
    {
        #region Fields

        private MouseState _currentMouse;
        private readonly InputManager input = new InputManager();
        private bool _isHovering;
        private MouseState _previousMouse;
        private Texture2D _showntexture; //the current texture for the button being shown
        private Texture2D _texture; //The texture for the button
        private SpriteFont _font;
        private Texture2D _texturehover; //Texture shown the mouse is hovering over the button

        #endregion

        #region Properties

        public event EventHandler onClicked; //Event is fired when the button is clicked
        public bool Clicked { get; private set; }
        public Color PenColor { get; private set; }
        public Vector2 Position { get; set; }
        public Rectangle Hitbox //Button hitbox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);
            }
        }
        public string Text { get; set; }
        
        #endregion

        #region Methods

        public Button(Texture2D texture, SpriteFont font, Texture2D hovertexture)
        {
            _showntexture = texture;
            _texture = texture;
            _font = font;
            _texturehover = hovertexture;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var color = Color.White;



            if (_isHovering)
                color = Color.Gray;

            spriteBatch.Draw(_showntexture, Hitbox, color);

            if (!string.IsNullOrEmpty(Text))
            {
                var x = (Hitbox.X + (Hitbox.Width / 2)) - (_font.MeasureString(Text).X / 2);
                var y = (Hitbox.Y + (Hitbox.Height / 2)) - (_font.MeasureString(Text).Y / 2);

                spriteBatch.DrawString(_font, Text, new Vector2(x, y), PenColor);
            }

        }

        public override void Update(GameTime gameTime)
        {
            _previousMouse = _currentMouse;
            _currentMouse = Mouse.GetState();

            if (_isHovering)
            {
                _showntexture = _texturehover;

            } else
            {
                _showntexture = _texture;
            }
            var mouseHitbox = new Rectangle(_currentMouse.X, _currentMouse.Y, 1, 1);


            _isHovering = false;

            if (mouseHitbox.Intersects(Hitbox))
            {
                _isHovering = true;

                if (input.Mouse.Is.Press(IMouse.Button.LEFT))
                {

                    onClicked?.Invoke(this, new EventArgs());
                }
            }
            input.Update();
        }

        #endregion
    }
}
