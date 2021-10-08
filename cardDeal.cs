using System;

namespace cse210_tc04
{
    class Card
    {
        int roundNum = 0;
        public bool IsFirstCard()
        {
                if (roundNum == 0)
                {
                    roundNum ++;
                    return true;
                }
                else
                {
                    roundNum ++;
                    return false;
                }
        }
        public int DrawCard()
        {
            Random ran = new Random();
            return ran.Next(1,14);
        }
        
        
    }
}