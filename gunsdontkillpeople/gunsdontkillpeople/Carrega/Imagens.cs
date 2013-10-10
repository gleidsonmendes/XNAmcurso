using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace gunsdontkillpeople
{
    public static class Imagens
    {
        public static Texture2D player_img;

        public struct player
        {
            public static Rectangle [] atirando = new Rectangle[4];
        }

        public static void Load(ContentManager Content)
        {
            player_img = Content.Load<Texture2D>(@"assets/player/player1");

            Animacao();
        }

        public static void Animacao()
        {
            player.atirando[0] = new Rectangle(0, 100, 120, 100);
            player.atirando[1] = new Rectangle(120, 50, 150, 150);
            player.atirando[2] = new Rectangle(270, 10, 100, 190);
            player.atirando[3] = new Rectangle(370, 30, 130, 170);
        }

        private static int index_atirar = 0;
        public static Rectangle Atirar()
        {
            return player.atirando[(index_atirar++)%4];
        }

        public static Rectangle Parado()
        {
            return player.atirando[0];
        }
    }

}
