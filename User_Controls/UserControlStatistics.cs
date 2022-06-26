using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using TermProjectCS.Classes;

namespace TermProjectCS.User_Controls
{
    public partial class UserControlStatistics : UserControl
    {
        public UserControlStatistics()
        {
            InitializeComponent();
        }
        public void UserControlStatistics_Load(object sender, EventArgs e)
        {
            ChangeTheme();
            SetNumberOfGames();
            SetNumberOfProfile();
            setHightestScore();
            setLowestScore();
            setMaximumDuration();
            setMinimunDuration();
            setTotalDuration();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
        }
        private void ChangeTheme()
        {
            label1.ForeColor = Form1.LastPlayer.colorofbg;
            label2.ForeColor = Form1.LastPlayer.colorofbg;
            label3.ForeColor = Form1.LastPlayer.colorofbg;
            label4.ForeColor = Form1.LastPlayer.colorofbg;
            LabelHS.ForeColor = Form1.LastPlayer.colorofbg;
            label6.ForeColor = Form1.LastPlayer.colorofbg;
            LabelLS.ForeColor = Form1.LastPlayer.colorofbg;
            label8.ForeColor = Form1.LastPlayer.colorofbg;
            LabelMaxD.ForeColor = Form1.LastPlayer.colorofbg;
            label10.ForeColor = Form1.LastPlayer.colorofbg;
            LabelMinD.ForeColor = Form1.LastPlayer.colorofbg;
            label12.ForeColor = Form1.LastPlayer.colorofbg;
            LabelNOF.ForeColor = Form1.LastPlayer.colorofbg;
            LabelNOP.ForeColor = Form1.LastPlayer.colorofbg;
            label15.ForeColor = Form1.LastPlayer.colorofbg;
            label17.ForeColor = Form1.LastPlayer.colorofbg;
            LabelTotalD.ForeColor = Form1.LastPlayer.colorofbg;
            BackButton.BackColor = Form1.LastPlayer.colorofbg;


        }
        private void SetNumberOfGames()
        {
            int sum=0;
            var q1 = from profile in Form1.Playerslist
                     select profile.G.Count;
            foreach(int i in q1)
            {
                sum = sum +i;
            }
            LabelNOF.Text = sum.ToString();
        }
        private void SetNumberOfProfile()
        {
            var q1 = from profile in Form1.Playerslist
                     select profile;
            LabelNOP.Text = $"{q1.Count()}";
        }
        private void setHightestScore()
        {
            int max = 0;
            var q1 = from Profile in Form1.Playerslist
                     select Profile.MaxScore;
            foreach (int i in q1)
            {
                if(i >=max)
                    max = i;
            }
            LabelHS.Text = max.ToString();
        }
        private void setLowestScore()
        {
            int min = 20;
            var q1 = from Profile in Form1.Playerslist
                     select Profile.MinScore;
            foreach (int i in q1)
            {
                if (i <= min)
                    min = i;
            }
            if (Form1.Playerslist.Count == 0)
                min = 0;
            LabelLS.Text = min.ToString();

        }
        private void setMaximumDuration()
        {
            int max = 0;
            var q1 = from Profile in Form1.Playerslist
                     select Profile.MaxDuration;
            foreach (int i in q1)
            {
                if (i >= max)
                    max = i;
            }
            LabelMaxD.Text = max.ToString();
        }
        private void setMinimunDuration()
        {
            int min = 20;
            var q1 = from Profile in Form1.Playerslist
                     select Profile.MinDuration;
            foreach (int i in q1)
            {
                if (i <= min)
                    min = i;
            }
            if (Form1.Playerslist.Count == 0)
                min = 0;
            LabelMinD.Text = min.ToString();
        }
        private void setTotalDuration()
        {
            int sum = 0;
            var q1 = from Profile in Form1.Playerslist
                     select Profile.TotalDuration;
            foreach (int i in q1)
            {               
                    sum = sum + i;
            }
            LabelTotalD.Text = sum.ToString();

        }

    }
}
