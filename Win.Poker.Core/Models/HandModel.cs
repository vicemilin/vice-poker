using System;
using System.Collections.Generic;
using Win.Poker.Core.Helpers;

namespace Win.Poker.Core.Models
{
	/// <summary>
	/// Description of HandModel.
	/// </summary>
	public class HandModel
	{
		private const int HAND_SIZE = 5;
		
		public HandState State { get; private set; }
		

		public HandModel()
		{
			State = new HandState();
		}
		
		public void Deal()
		{
			if(!State.FirstDeal)
			{
				FillCurrent();
				State.FirstDeal = true;
			}
			else if(!State.SecondDeal)
			{
				for(int i = 0; i < HAND_SIZE; i++)
                {
                    if (!State.HeldCards[i])
                    {
						State.ThrownCards[i] = State.CurrentCards[i].Clone();
						State.CurrentCards[i] = null;
                    }
                }
				FillCurrent();
				State.SecondDeal = true;
			}
            else 
			{
				Reset();
			}
		}
		
		public void Hold(int index)
		{
			if(State.FirstDeal && !State.SecondDeal && index >= 0 && index < 5)
				State.HeldCards[index] = !State.HeldCards[index];
		}
		
		public void Reset()
		{
			State = new HandState();
		}
		
		public HandResult GetResult()
        {
			/*
			 * Results must be checked from highest value wins to lowest because some higher value win would be lower value win also
			 * eg. RoyalFlush win is also a StraightFlush, Straight and a Flush win so if we checked wins in any random order we would get incorrect results
			*/
			if (CheckRoyalFlush())
				return HandResult.RoyalFlush;
			if (CheckStraightFlush())
				return HandResult.StraightFlush;
			if (CheckFourOfAKind())
				return HandResult.FourOfAKind;
			if (CheckFullHouse())
				return HandResult.FullHouse;
			if (CheckFlush())
				return HandResult.Flush;
			if (CheckStraight())
				return HandResult.Straight;
			if (CheckThreeOfAKind())
				return HandResult.ThreeOfAKind;
			if (CheckTwoPairs())
				return HandResult.TwoPairs;
			if (CheckJacksOrBetter())
				return HandResult.JacksOrBetter;

			return HandResult.None;
        }

		#region Private
		
		private void FillCurrent()
		{
			for(int i = 0; i < HAND_SIZE; i++)
			{
				if(State.CurrentCards[i] == null)
                {
                    while (true)
                    {
						var newCard = CardGenerator.GetRandomCard();
						if (!IsAlreadyDealt(newCard))
						{
							State.CurrentCards[i] = newCard;
							break;
						}
                    }
                }
			}
		}
		
		private bool IsAlreadyDealt(CardModel card)
		{
			return Array.FindIndex<CardModel>(State.CurrentCards, x => card.Equals(x)) >= 0 || Array.FindIndex<CardModel>(State.ThrownCards, x => card.Equals(x)) >= 0;
		}

        #endregion

        #region Results
		private bool CheckRoyalFlush()
        {
			var numbers = GetCurrentHandNumbers();
			Array.Sort(numbers);
			return numbers[0] == 1 && numbers[1] == 10 && numbers[2] == 11 && numbers[3] == 12 && numbers[4] == 13 && CheckFlush();
        }

		private bool CheckStraightFlush()
        {
			return CheckStraight() && CheckFlush();
        }

		private bool CheckFourOfAKind()
        {
			var numbers = GetSameNumbersArray();
			Array.Sort(numbers);
			return numbers[12] == 4;
		}

		private bool CheckFullHouse()
		{
			var numbers = GetSameNumbersArray();
			Array.Sort(numbers);
			return numbers[12] == 3 && numbers[11] == 2;
		}

		private bool CheckFlush()
        {
			var firstColor = State.CurrentCards[0].Color;
			return Array.TrueForAll<CardModel>(State.CurrentCards, x => x.Color == firstColor);
        }

		private bool CheckStraight()
        {
			var numbers = GetCurrentHandNumbers();
			Array.Sort(numbers);
			//Check special case from 10 to A straight
			if (numbers[0] == 1 && numbers[1] == 10 && numbers[2] == 11 && numbers[3] == 12 && numbers[4] == 13)
				return true;

			for(int i = 0; i < HAND_SIZE - 1; i++)
            {
                if (!(numbers[i] + 1 == numbers[i + 1]))
					return false;
            }
			return true;
		}

		private bool CheckThreeOfAKind()
		{
			var numbers = GetSameNumbersArray();
			Array.Sort(numbers);
			return numbers[12] == 3;
		}

		private bool CheckTwoPairs()
		{
			var numbers = GetSameNumbersArray();
			Array.Sort(numbers);
			return numbers[12] == 2 && numbers[11] == 2;
		}

		private bool CheckJacksOrBetter()
		{
			var numbers = GetSameNumbersArray();
			return numbers[0] == 2 || numbers[10] == 2 || numbers[11] == 2 || numbers[12] == 2;
		}
		#endregion

		#region Helpers
		public byte[] GetCurrentHandNumbers()
        {
			var numbers = new byte[HAND_SIZE];
			for(int i = 0; i < HAND_SIZE; i++)
            {
				numbers[i] = State.CurrentCards[i].Number;
            }
			return numbers;
        }

		/// <summary>
		/// Returns array of 13 numbers where each element in array represents how many times does some hand appear in array
		/// </summary>
		/// <returns></returns>
		private byte[] GetSameNumbersArray()
        {
			var numbers = new byte[13];
			for(int i = 0; i < HAND_SIZE; i++)
            {
				numbers[State.CurrentCards[i].Number - 1]++;
            }
			return numbers;
        }
        #endregion
    }
}
