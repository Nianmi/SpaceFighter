using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFighter.Screens
{
    class SplashScreen : GameScreen
    {
        Texture2D text;

        public override void Initialize()
        {
            
            base.Initialize();
        }

        public override void LoadContent()
        {
            EntityManager.Add(PlayerShip.Instance);
            text = Art.Wanderer;
            base.LoadContent();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
            Color col = Color.White;
            Vector2 vec = new Vector2(5.0f, 5.0f);

            spriteBatch.Draw(text, vec, col);


            //    spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
            EntityManager.Draw(spriteBatch);
            //    spriteBatch.End();
        }


    }
}
