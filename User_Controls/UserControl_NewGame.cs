using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TermProjectCS.Classes;

namespace TermProjectCS.User_Controls
{
    public partial class UserControl_NewGame : UserControl
    {
        private Players Player;
        public static Games Game;
        public static int level1, level2, level3, level4, level5;
        User_Controls.GameLevels.Level1 Level_1;
        User_Controls.GameLevels.Level2 Level_2;
        User_Controls.GameLevels.Level3 Level_3;
        User_Controls.GameLevels.Level4 Level_4;
        User_Controls.GameLevels.Level5 Level_5;

        public UserControl_NewGame(Players P)
        {
            InitializeComponent();
            Player = P;
            Game = new Games();

            Level_1 = new GameLevels.Level1();
            Level_2 = new GameLevels.Level2();
            Level_3 = new GameLevels.Level3();
            Level_4 = new GameLevels.Level4();
            Level_5 = new GameLevels.Level5();
            Label_UserName.Text = "User name :" + Player.Name;


            level1 = 0;
            level2 = 0;
            level3 = 0;
            level4 = 0;
            level5 = 0;
        }

        public void UserControl_NewGame_Load(object sender, EventArgs e)
        {
            ChangeTheme();

            Duration.Start();
            Duration.Interval = 1000;

            int Y = panel2.Location.Y + panel2.Height + 5;
            int X = this.Width / 2;

            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);

            Level_1.Location = new System.Drawing.Point(X - (Level_1.Width / 2), Y);
            Level_2.Location = new System.Drawing.Point(X - (Level_2.Width / 2), Y);
            Level_3.Location = new System.Drawing.Point(X - (Level_3.Width / 2), Y);
            Level_4.Location = new System.Drawing.Point(X - (Level_4.Width / 2), Y); 
            Level_5.Location = new System.Drawing.Point(X - (Level_5.Width / 2), Y); 

            this.Controls.Add(Level_1);
            this.Controls.Add(Level_2);
            this.Controls.Add(Level_3);
            this.Controls.Add(Level_4);
            this.Controls.Add(Level_5);


            Level_1.Visible = true;
            Level_2.Visible = false;
            Level_3.Visible = false;
            Level_4.Visible = false;
            Level_5.Visible = false;


        }
        private void Duration_Tick(object sender, EventArgs e)
        {
            Label_Duration.Text = "Duration(Seconds): " + Game.Duration;
            Label_level.Text = "Level :"+Game.Level;
            Label_Score.Text = "Scores :" + Game.Score;
            Label_NumOfSuccessful.Text = "Numbers Of successful clicks :" + Game.NumOfSuccessfulClicks;
            Label_NumOFWrong.Text = "Numbers Of wrong clicks :" + Game.NumOfWrongClicks;
            Game.Duration++;
            if (level1 == 2)
            {
                Level_1.Visible = false;
                Level_2.Visible = true;
                level1++;
                Game.Level++;
            }
            if (level2 == 4)
            {
                Level_2.Visible = false;
                Level_3.Visible = true;
                level2++;
                Game.Level++;

            }
            if (level3 == 8)
            {
                Level_3.Visible = false;
                Level_4.Visible = true;
                level3++;
                Game.Level++;

            }
            if (level4 == 12)
            {
                Level_4.Visible = false;
                Level_5.Visible = true;
                level4++;
                Game.Level++;
            }
            if (level5 == 18)
            {
                Level_5.Visible = false;
                level5++;
            }
            if (level5 == 19 )
            {
                level5++;
                FinishGame();
            }
        }     
        private void pictureBox_ExitGame_Click(object sender, EventArgs e)
        {
            FinishGame();
        }
        private void ChangeTheme()
        {
            Label_UserName.ForeColor = Player.colorofbg;
            Label_Score.ForeColor = Player.colorofbg;
            Label_Duration.ForeColor = Player.colorofbg;
            Label_level.ForeColor = Player.colorofbg;
            Label_NumOfSuccessful.ForeColor = Player.colorofbg;
            Label_NumOFWrong.ForeColor = Player.colorofbg;
            label2.ForeColor = Player.colorofbg;
        }
        private void FinishGame()
        {
            Player.G.Add(Game);
            Player.setData();
            Game = new Games();
            this.Visible = false;
            Duration.Stop();
        }
    }
}
