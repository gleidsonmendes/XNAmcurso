using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace gunsdontkillpeople
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Imagens imagens;
        int x;

        //Sprite do player
        public Texture2D player;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            x = 100;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = Content.Load<Texture2D>(@"assets\player\player");

        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            KeyboardState key = Keyboard.GetState();

            if (key.IsKeyDown(Keys.Left) || key.IsKeyDown(Keys.A)) x -= 5;
            if (key.IsKeyDown(Keys.Right) || key.IsKeyDown(Keys.D)) x += 5;
            if (x >= 680) x -= 5;
            if (x <= 0) x += 5;


            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(player, new Vector2(x, 500), new Rectangle(0, 100, 120, 100), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
