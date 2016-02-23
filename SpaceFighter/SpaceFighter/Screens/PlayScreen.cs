using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFighter.Screens
{
    class PlayScreen : GameScreen
    {

        public override void Initialize()
        {
            base.Initialize();

            //TODO: Add your Initialize logic here
            EntityManager.Add(PlayerShip.Instance);
            LevelReader.readLevelData();
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

            // TODO: Add your update logic here

            EntityManager.Update();
            EnemySpawner.Update();
            PlayerStatus.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

        //TODO: Add your Draw logic here
                spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
            EntityManager.Draw(spriteBatch);
            spriteBatch.End();

            spriteBatch.Begin(0, BlendState.Additive);

            spriteBatch.DrawString(Art.Font, "Lives: " + PlayerStatus.Lives, new Vector2(5), Color.White);
            drawRightAlignedString("Score: " + PlayerStatus.Score, 5, Color.White);
            drawRightAlignedString("Multiplier: " + PlayerStatus.Multiplier, 35, Color.White);


            if (PlayerStatus.IsGameOver)
            {
                string text = "Game Over\n" +
                    "Your Score: " + PlayerStatus.Score + "\n" +
                    "High Score: " + PlayerStatus.HighScore;

                drawCentertAlignedString(text, Color.White);
            }

            // draw the custom mouse cursor
            spriteBatch.Draw(Art.Pointer, Input.MousePosition, Color.White);

            spriteBatch.End();
        }
    }
}
