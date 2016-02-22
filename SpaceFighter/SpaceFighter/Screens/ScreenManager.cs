using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFighter.Screens
{
    class ScreenManager
    {
        private static ScreenManager instance;
        public Vector2 Dimensions { private set; get; }
        public ContentManager Content { private set; get; }

        public GraphicsDevice GraphicsDevice;
        public SpriteBatch SpriteBatch;

        GameScreen currentScreen;

        public static ScreenManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ScreenManager();
                }
                return instance;
            }
        }

        private ScreenManager()
       {
            Dimensions = new Vector2(1280, 720);
            currentScreen = new SplashScreen();
       }

        public void Initialize()
        {
            currentScreen.Initialize();
        }

        public void LoadContent(ContentManager Content)
        {
            this.Content = Content;
            currentScreen.LoadContent();
        }

        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }
        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }

    }
}
