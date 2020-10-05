using System;
using System.Collections.Generic;
using System.Text;

namespace Win.Poker.Core.Models
{
    public class HandState
    {
        public HandState()
        {
            CurrentCards = new CardModel[5];
            ThrownCards = new CardModel[5];
            HeldCards = new bool[5];
            FirstDeal = false;
            SecondDeal = false;
        }

        public CardModel[] CurrentCards { get; internal set; }
        public CardModel[] ThrownCards { get; internal set; }
        public bool[] HeldCards { get; internal set; }
        public bool FirstDeal { get; internal set; }
        public bool SecondDeal { get; internal set; }
    }
}
