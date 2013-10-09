using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace gunsdontkillpeople
{
    public class Player
    {
        private int x;

        public Player()
        {
            this.initialize();
        }

        public void initialize()
        {
            x = 100;
        }

        public void update(GameTime gameTime)
        {
            KeyboardState key = Keyboard.GetState();

            if (key.IsKeyDown(Keys.Left) || key.IsKeyDown(Keys.A)) x -= 5;
            if (key.IsKeyDown(Keys.Right) || key.IsKeyDown(Keys.D)) x += 5;
            if (x >= 680) x -= 5;
            if (x <= 0) x += 5;
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Imagens.player, new Vector2(x, 500), new Rectangle(0, 100, 120, 100), Color.White);
        }

    }
}
