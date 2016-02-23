using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SpaceFighter.Screens;

namespace SpaceFighter
{
    public class GameScreen
    {

        protected SpriteBatch spriteBatch;
        protected ContentManager content;

        public GameScreen()
        {

        }

        public virtual void Initialize()
        {
            spriteBatch = ScreenManager.Instance.SpriteBatch;
        }

        public virtual void LoadContent()
        {
            content = ScreenManager.Instance.Content;
        }

        public virtual void UnloadContent()
        {
            content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {
            Input.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }

        //i think thes opitis are at the wrong place ;)
        #region StringDrawOpions
        public void drawCentertAlignedString(string text, Color color)
        {
            Vector2 textSize = Art.Font.MeasureString(text);
            spriteBatch.DrawString(Art.Font, text, new Vector2(GameRoot.ScreenSize.X / 2 - textSize.X / 2, GameRoot.ScreenSize.Y / 2 - textSize.Y / 2), color);
        }

        public void drawRightAlignedString(string text, float y, Color color)
        {
            var textWidth = Art.Font.MeasureString(text).X;
            spriteBatch.DrawString(Art.Font, text, new Vector2(GameRoot.ScreenSize.X - textWidth - 5, y), color);
        }
        #endregion
    }
}
