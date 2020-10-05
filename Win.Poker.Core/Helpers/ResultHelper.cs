using System;
using System.Collections.Generic;
using System.Text;

namespace Win.Poker.Core.Helpers
{
    public static class ResultHelper
    {
        public static string GetResultName(HandResult result)
        {
            switch (result)
            {
                case HandResult.JacksOrBetter:
                    return "Jacks Or Better";
                case HandResult.TwoPairs:
                    return "Two Pairs";
                case HandResult.ThreeOfAKind:
                    return "Three of a Kind";
                case HandResult.Straight:
                case HandResult.Flush:
                    return result.ToString();
                case HandResult.FullHouse:
                    return "Full House";
                case HandResult.FourOfAKind:
                    return "Four of a Kind";
                case HandResult.StraightFlush:
                    return "Straight Flush";
                case HandResult.RoyalFlush:
                    return "Royal Flush";
                default:
                    return null;
            }
        }
    }
}
