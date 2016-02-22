using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using SpaceFighter.Screens;

namespace SpaceFighter
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameRoot : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public static GameRoot Instance { get; private set; }
        public static Viewport Viewport { get { return Instance.GraphicsDevice.Viewport; } }
        public static Vector2 ScreenSize { get { return new Vector2(Viewport.Width, Viewport.Height); } }

        public static GameTime GameTime { get; private set; }

        public GameRoot()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            Instance = this;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            graphics.PreferredBackBufferHeight = (int)ScreenManager.Instance.Dimensions.Y;
            graphics.PreferredBackBufferWidth = (int)ScreenManager.Instance.Dimensions.X;
            graphics.ApplyChanges();

            //ScreenManager.Instance.Initialize();
            //  EntityManager.Add(PlayerShip.Instance);

            //debug bases 
            //LevelReader.readLevelData();

            Art.Load(Content);
            Sound.Load(Content);

            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(Sound.Music);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            Art.Load(Content);
            Sound.Load(Content);

            ScreenManager.Instance.GraphicsDevice = GraphicsDevice;
            ScreenManager.Instance.SpriteBatch = spriteBatch;
            ScreenManager.Instance.LoadContent(Content);

            //Art.Load(Content);
            //Sound.Load(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            ScreenManager.Instance.UnloadContent();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            GameTime = gameTime;

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            ScreenManager.Instance.Update(gameTime);

            //Input.Update();
            //EntityManager.Update();
            //EnemySpawner.Update();
            //PlayerStatus.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // Clear the backbufferG
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            ScreenManager.Instance.Draw(spriteBatch);
            spriteBatch.End();

            //    GraphicsDevice.Clear(Color.Black);

            //    spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
            //    EntityManager.Draw(spriteBatch);
            //    spriteBatch.End();

            //    spriteBatch.Begin(0, BlendState.Additive);

            //    spriteBatch.DrawString(Art.Font, "Lives: " + PlayerStatus.Lives, new Vector2(5), Color.White);
            //    DrawRightAlignedString("Score: " + PlayerStatus.Score, 5);
            //    DrawRightAlignedString("Multiplier: " + PlayerStatus.Multiplier, 35);


            //    if (PlayerStatus.IsGameOver)
            //    {
            //        string text = "Game Over\n" +
            //            "Your Score: " + PlayerStatus.Score + "\n" +
            //            "High Score: " + PlayerStatus.HighScore;

            //        Vector2 textSize = Art.Font.MeasureString(text);
            //        spriteBatch.DrawString(Art.Font, text, ScreenSize / 2 - textSize / 2, Color.White);
            //    }

            //    // draw the custom mouse cursor
            //    spriteBatch.Draw(Art.Pointer, Input.MousePosition, Color.White);

            //    spriteBatch.End();
            //}

            //private void DrawRightAlignedString(string text, float y)
            //{
            //    var textWidth = Art.Font.MeasureString(text).X;
            //    spriteBatch.DrawString(Art.Font, text, new Vector2(ScreenSize.X - textWidth - 5, y), Color.White);


            base.Draw(gameTime);
        }
    }
    }
