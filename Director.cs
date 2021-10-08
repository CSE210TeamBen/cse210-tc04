using System;

namespace cse210_tc04
{
    class Director
    {
        public int card1 = 0;
        public int card2 = 0;
        public int _score = 300;
        public bool keepPlaying = true;
        public Card _dealer = new Card();
        public void StartGame()
        {
            while(keepPlaying)
            {
                GetInputs();
                if (keepPlaying)
                {
                    DoUpdates();
                    DoOutputs();
                }
            }
        }
        void GetInputs()
        {
             if (!_dealer.IsFirstCard())
            {
                Console.WriteLine("Roll again? [y/n] ");
                string choice = Console.ReadLine();
                keepPlaying = (choice == "y");
                if (!keepPlaying)
                {
                    Console.WriteLine("Game Over.");
                }
            }
        }
        void getGuess()
        {
            Console.Write("Higher or lower? [h/l]  ");
            string guess = Console.ReadLine().ToLower();
            if (card1 < card2 && guess == "h")
            {
                _score += 100;
            }
            else if (card1 > card2 && guess == "l")
            {
                _score += 100;
            }
            else
            {
                _score -= 75;
            }
        }
        void DoUpdates()
        {
            card1 = _dealer.DrawCard();
            card2 = _dealer.DrawCard();
            Console.WriteLine($"The card is: {card1}");
            getGuess();
            if (_score <= 0)
            {
                _score =0;
                keepPlaying = false;
            }
        }
        void DoOutputs()
        {
            Console.WriteLine($"Next card was: {card2}");
            Console.WriteLine($"Your score is: {_score}");
            if (!keepPlaying)
            {
                Console.WriteLine("Game Over.");
            }
        }

    }
}
