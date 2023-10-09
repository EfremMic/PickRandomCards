namespace PickRandomCards
{
    internal class CardPicker
    {
        //Create instance of the `Random` class in a static context
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
        /*
         * 
         * Sets of CardValue and CardSuit i`m going to use
         CardSuits:
        1) Hearts
        2) Dimonds
        3) Clubs
        4) Spades
        
         Card Values (In ascending order)
        1) Ace
        2) Two
        3) Three
        4) Four
        5) Five
        6) Six
        7) Seven
        8) Eight
        9) Nine
        10) Ten
        11) Jack
        12) Queen
        13) King
        */
        private static string RandomValue()
        {
            //get random value from 1 to 14
            int value = random.Next(1, 14);
            //if it`s 1 return the string Ace
            if (value == 1) return "Ace";
            //if it`s 11 return the string Jack
            if (value == 11) return "Jack";
            //if it`s 12 return the string Queen
            if (value == 12) return "Queen";
            //if it`s 13 return the string King
            if (value == 13) return "King";
            return value.ToString();
        }
        private static string RandomSuit()
        {
            //get a random number from 1 to 4
            int value = random.Next(1, 5);
            //if it`s 1 return the string spades
            if (value == 1) return "Spades";
            //if it`s 2 return the string hearts
            if (value == 2) return "Hearts";
            //if it`s 3 retuen the string Clubs
            if (value == 3) return "Clubs";
            //if we haven`t returned yet, return the string Dimonds
            return "Dimonds";
        }


    }
}
