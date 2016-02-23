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
        private bool wasKeyPressed = false;

        public override void Initialize()
        {
            base.Initialize();

            //TODO: Add your Initialize logic here
        }

        public override void LoadContent()
        {
            base.LoadContent();

            // TODO: Add your LoadContent logic here
        }

        public override void UnloadContent()
        {
            base.UnloadContent();

            // TODO: Add your UnloadContent logic here
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            wasKeyPressed = Input.wasAnyKeyPressed();
            // TODO: Add your update logic here
            if (wasKeyPressed == true)
            {
                ScreenManager.Instance.changeScreens("PlayScreen");
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

            // TODO: Add your Draw logic here
            spriteBatch.Begin(0, BlendState.Additive);
            drawCentertAlignedString("Press Any Key To Continue", Color.White);
            spriteBatch.End();
        }
    }
}
