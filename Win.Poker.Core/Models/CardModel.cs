using System;

namespace Win.Poker.Core.Models
{
	/// <summary>
	/// Holding color and number info about card
	/// For simplicity number is a integer from 1 to 13, 1 being A and 11, 12, 13 J, Q, K
	/// </summary>
	public class CardModel
	{
		/// <summary>
		/// default constructor is not strictly needed (it just creates Ace of Spades) 
		/// </summary>
		public CardModel()
		{
			Number = 1;
			Color = CardColor.Spades;
		}
		
		
		/// <summary>
		/// always use this constructor
		/// </summary>
		/// <param name="number"></param>
		/// <param name="color"></param>
		public CardModel(byte number, CardColor color)
		{
			Number = number;
			Color = color;
		}
		
		public byte Number { get; } //using byte instead of int because all possible values are in range 1-13
		public CardColor Color { get; } //both properties are read-only

        public override bool Equals(object card)
        {
			return card != null && card is CardModel && ((CardModel)card).Color == Color && ((CardModel)card).Number == Number;
        }

		public CardModel Clone()
        {
			return new CardModel(Number, Color);
        }
    }
}
