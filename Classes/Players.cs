using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TermProjectCS.Classes
{
    public class Players
    {
        public string Name;
        public int Age;
        public string Gender;
        public List<Games> G;
        public Color colorofbg;
        public int MaxDuration , MinDuration ,MaxScore , MinScore,TotalDuration;
        public Players()
        {
            colorofbg = Color.Orange;
            G = new List<Games>();
            Name = "UnKnown";
            Gender = "Male";
            Age = 10;
            MaxDuration = 0;
            MinDuration = 100;
            MaxScore = 0;
            MinScore = 100;
            TotalDuration = 0;
        }
        public Players(Players p)
        {
            colorofbg = p.colorofbg;
            Name = p.Name;
            Gender = p.Gender;
            Age = p.Age;
            MaxDuration = p.MaxDuration;
            MinDuration = p.MinDuration;
            MaxScore = p.MaxScore;
            MinScore = p.MinScore;
            TotalDuration = p.TotalDuration;
            G = new List<Games>();
            for(int i=0;i<p.G.Count;i++)
            {
                G.Add(new Games(p.G[i]));
            }
        }
        public void setData()
        {
            TotalDuration = 0;
            foreach (Games g in G)
            {
                if (g.Duration >= MaxDuration)
                    MaxDuration = g.Duration;
            }
            foreach (Games g in G)
            {
                if (g.Duration <= MinDuration)
                    MinDuration = g.Duration;
            }
            foreach (Games g in G)
            {
                if (g.Score >= MaxScore)
                    MaxScore = g.Score;
            }
            foreach (Games g in G)
            {
                if (g.Score <= MinScore)
                    MinScore = g.Score;
            }
            foreach (Games g in G)
            { 
                TotalDuration = TotalDuration + g.Duration;
            }
        }
    }
}
