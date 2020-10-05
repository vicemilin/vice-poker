using System;

namespace Win.Poker.Core
{
	public enum CardColor
	{
		Clubs,
		Spades,
		Hearts,
		Diamonds
	}

	/// <summary>
	/// Types of winning hands with multipliers as values, None means no win
	/// </summary>
	public enum HandResult
    {
		None = 0,
		JacksOrBetter = 1,
		TwoPairs = 2,
		ThreeOfAKind = 3,
		Straight = 4,
		Flush = 6,
		FullHouse = 9,
		FourOfAKind = 25,
		StraightFlush = 50,
		RoyalFlush = 800
    }

	public enum DoubleColor
    {
		Red,
		Black
    }
}
