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
		private CardModel[] _currentCards;
		private CardModel[] _thrownCards;
		private bool[] _held;
		
		private bool _firstDeal = false;
		private bool _secondDeal = false;
		

		public HandModel()
		{
			_currentCards = new CardModel[HAND_SIZE];
			_thrownCards = new CardModel[HAND_SIZE];
			_held = new bool[HAND_SIZE];
		}
		
		public CardModel[] Deal()
		{
			if(!_firstDeal)
			{
				FillCurrent();
				_firstDeal = true;
			}
			else if(!_secondDeal)
			{
				for(int i = 0; i < HAND_SIZE; i++)
                {
                    if (_held[i])
                    {
						_thrownCards[i] = _currentCards[i].Clone();
						_currentCards[i] = null;
                    }
                }
			}
            else { }
			
			return _currentCards;
		}
		
		public bool[] Hold(int index)
		{
			if(_firstDeal && !_secondDeal && index >= 0 && index < 5)
				_held[index] = !_held[index];
			return _held;
		}
		
		public void Reset()
		{
			_currentCards = new CardModel[HAND_SIZE];
			_thrownCards = new CardModel[HAND_SIZE];
			_held = new bool[HAND_SIZE];
			_firstDeal = false;
			_secondDeal = false;
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
				if(_currentCards[i] == null)
                {
                    while (true)
                    {
						var newCard = CardGenerator.GetRandomCard();
						if (!IsAlreadyDealt(newCard))
						{
							_currentCards[i] = newCard;
							break;
						}
                    }
                }
			}
		}
		
		private bool IsAlreadyDealt(CardModel card)
		{
			return Array.FindIndex<CardModel>(_currentCards, x => card.Equals(x)) >= 0 || Array.FindIndex<CardModel>(_thrownCards, x => card.Equals(x)) >= 0;
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
			var firstColor = _currentCards[0].Color;
			return Array.TrueForAll<CardModel>(_currentCards, x => x.Color == firstColor);
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
			Array.Sort(numbers);
			return numbers[0] == 2 || numbers[10] == 2 || numbers[11] == 2 || numbers[12] == 2;
		}
		#endregion

		#region Helpers
		public byte[] GetCurrentHandNumbers()
        {
			var numbers = new byte[HAND_SIZE];
			for(int i = 0; i < HAND_SIZE; i++)
            {
				numbers[i] = _currentCards[i].Number;
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
				numbers[_currentCards[i].Number - 1]++;
            }
			return numbers;
        }
        #endregion
    }
}
