using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace gunsdontkillpeople
{
    public static class Imagens
    {
        public static Texture2D player;

        public static void Load(ContentManager Content)
        {
            player = Content.Load<Texture2D>(@"assets/player/player");
        }
    }
}
