using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Win.Poker.Core.Models;

namespace Win.Poker.Helpers
{
    public static class ImageHelper
    {
        private static Bitmap _cardBackground = Properties.Resources.background;
        public static Bitmap[,] _cardImages;

        public static void LoadCardImages()
        {
            Bitmap cards = Properties.Resources.cards;
            _cardImages = new Bitmap[13, 4];

            var singleCardWidth = cards.Width / 13;
            var singleCardHeight = cards.Height / 4;
            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Bitmap c = new Bitmap(singleCardWidth, singleCardHeight);
                    using(Graphics g = Graphics.FromImage(c))
                    {
                        g.DrawImage(cards, new Rectangle(0, 0, singleCardWidth, singleCardHeight), new Rectangle(singleCardWidth * i, singleCardHeight * j, singleCardWidth, singleCardHeight), GraphicsUnit.Pixel);
                        g.Flush();
                    }
                    _cardImages[i, j] = c;
                }
            }
        }

        public static Bitmap Background { get { return _cardBackground; } }
        
        public static Bitmap GetCardImage(CardModel card)
        {
            if (card == null)
                return Background;
            return _cardImages[card.Number - 1, (int)card.Color];
        }
    }
}
