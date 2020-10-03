using System;

namespace Win.Poker.Core.Helpers
{
	/// <summary>
	/// Has only one static method that returns a randomly generated CardModel
	/// </summary>
	public static class CardGenerator
	{
		private static readonly CardColor[] _colors = new CardColor[4] { CardColor.Spades, CardColor.Clubs, CardColor.Hearts, CardColor.Diamonds};
		private static readonly Random _rng = new Random(); //Random class should be random enough for this type of project
		
		public static CardModel GetRandomCard(){
			return new CardModel(_rng.Next(1,14), _colors[_rng.Next(0,4)]);
		}
	}
}
