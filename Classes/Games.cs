using System;
using System.Collections.Generic;
using System.Text;

namespace TermProjectCS.Classes
{
    public class Games
    {
        public int Level;
        public int Score;
        public int NumOfSuccessfulClicks;
        public int NumOfWrongClicks;
        public int Duration;
        public DateTime date;
        public string[] steps ;
        public Games()
        {
            Level = 1;
            Score = 0;
            NumOfSuccessfulClicks = 0;
            NumOfWrongClicks = 0;
            Duration = 0;
            date = DateTime.Today;
            steps = new string[4];
        }
        public Games(Games g)
        {
            Level = g.Level;
            Score = g.Score;
            NumOfSuccessfulClicks = g.NumOfSuccessfulClicks;
            NumOfWrongClicks = g.NumOfWrongClicks;
            Duration = g.Duration;
            date = g.date;
            steps = new string[4];
            for (int i=0;i<4;i++)
            {
                steps[i] = g.steps[i];
            }
        }
    }
}
