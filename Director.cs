using System;

namespace cse210_tc04
{
    class Director
    {
        public int card1 = 0;
        public int card2 = 0;
        public int score = 0;
        public bool keepPlaying = true;
        public Card _card = new Card();
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
            throw new NotImplementedException();
        }
        void DoOutputs()
        {
            throw new NotImplementedException();
        }
        void DoUpdates()
        {
            throw new NotImplementedException();
        }

    }
}
