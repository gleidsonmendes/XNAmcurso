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

    public class Game
    {

        Player player;

        public Game()
        {
            iniatialize();
        }

        private void iniatialize()
        {
            player = new Player();
        }

        public void load()
        {
                
        }

        public void update(GameTime gameTime)
        {
            player.update(gameTime);
        }

        public void draw(SpriteBatch spBacth)
        {
            player.draw(spBacth);
        }
    }
}
