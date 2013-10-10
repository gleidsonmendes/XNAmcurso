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

        private bool active_shoot;
        
        public Player()
        {
            this.initialize();
        }

        public void initialize()
        {
            x = 100;
            active_shoot = false;
        }

        public void update(GameTime gameTime)
        {
            KeyboardState key = Keyboard.GetState();

            if (key.IsKeyDown(Keys.Left) || key.IsKeyDown(Keys.A)) x -= 5;
            if (key.IsKeyDown(Keys.Right) || key.IsKeyDown(Keys.D)) x += 5;
            if (x >= 680) x -= 5;
            if (x <= 0) x += 5;

            if (key.IsKeyDown(Keys.Space))
            {
                active_shoot = true;
            }
            else
            {
                active_shoot = false;
            }
        }

        public void draw(SpriteBatch spriteBatch)
        {
            
            if (active_shoot)
            {
                spriteBatch.Draw(Imagens.player_img, new Vector2(x, 100), Imagens.Atirar(), Color.White);
            }
            else
            {
                spriteBatch.Draw(Imagens.player_img, new Vector2(x, 100), Imagens.Parado(), Color.White);
            }

        }
    }
}
