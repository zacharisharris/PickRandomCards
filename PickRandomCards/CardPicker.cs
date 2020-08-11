﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        static string RandomSuit()
        {
            int value = random.Next(1, 4);

            if (value == 1) { return "Spades"; }
            if (value == 2) { return "Hearts"; }
            if (value == 3) { return "Spades"; }

            return "Diamonds";
        }

        static string RandomValue()
        {
            int value = random.Next(1, 14);

            if (value == 1) { return "Ace"; }
            if (value == 11) { return "Jack"; }
            if (value == 12) { return "Queen"; }
            if (value == 13) { return "King"; }

            return value.ToString();

        }
    }
}
