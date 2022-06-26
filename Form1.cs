using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TermProjectCS.Classes;

namespace TermProjectCS
{
    public partial class Form1 : Form
    {
        public static List<Players> Playerslist;
        public static Players LastPlayer , PenultimatePlayer;
        public static Timer timer1 = new Timer();

        User_Controls.UserControl_SelectProfile SelectProfile = new User_Controls.UserControl_SelectProfile();
        User_Controls.UserControl_CurrentProfiles CurrentProfiles = new User_Controls.UserControl_CurrentProfiles();
        User_Controls.UserControlNewProfiles NewProfiles = new User_Controls.UserControlNewProfiles();
        User_Controls.UserControlStatistics Statistics = new User_Controls.UserControlStatistics();
        User_Controls.UserControl_History History = new User_Controls.UserControl_History();
        User_Controls.UserControl_NewGame NewGame = null;



        public Form1()
        {
            InitializeComponent();
            Playerslist = new List<Players>();
            LastPlayer = new Players();
            PenultimatePlayer = new Players();
        }
        /// <summary>
        /// location of panels :  14; 67 
        /// size of panels : 763; 424
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            Point LocOfControls = new Point();
            LocOfControls.X = StartButton.Location.X;
            LocOfControls.Y = StartButton.Location.Y + StartButton.Height;
            //////////////////////
            this.Controls.Add(SelectProfile);
            SelectProfile.BackColor = Color.FromArgb(100, 0, 0, 0);
            SelectProfile.Location = LocOfControls;
            SelectProfile.Visible = false;
            ////////
            this.Controls.Add(CurrentProfiles);
            CurrentProfiles.BackColor = Color.FromArgb(100, 0, 0, 0);
            CurrentProfiles.Location = LocOfControls;
            CurrentProfiles.Visible = false;
            ////////
            this.Controls.Add(NewProfiles);            
            NewProfiles.BackColor = Color.FromArgb(100, 0, 0, 0);
            NewProfiles.Location = LocOfControls ;
            NewProfiles.Visible = false;
            ////////
            this.Controls.Add(Statistics);
            Statistics.BackColor = Color.FromArgb(100, 0, 0, 0);
            Statistics.Location = LocOfControls;
            Statistics.Visible = false;
            ///////
            this.Controls.Add(History);
            History.BackColor = Color.FromArgb(100, 0, 0, 0);
            History.Location = LocOfControls;
            History.Visible = false;
            ////////////
            timer1.Interval = 10;
        }


        //Buttons of Labels:
        private void Startbutton_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = true;
            ProfilePanel.Visible = false;
            ReportPanel.Visible = false;
            ExitPanel.Visible = false;
        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
            ProfilePanel.Visible = true;
            ReportPanel.Visible = false;
            ExitPanel.Visible = false;
        }
        private void ReportButton_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
            ProfilePanel.Visible = false;
            ReportPanel.Visible = true;
            ExitPanel.Visible = false;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
            ProfilePanel.Visible = false;
            ReportPanel.Visible = false;
            ExitPanel.Visible = true;
        }


        //////////////////////////////////Start Label:
        private void NewButton_Click(object sender, EventArgs e)
        {
            PenultimatePlayer = new Players(LastPlayer);
            SelectProfile.UserControl_SelectProfile_Load(null, null);
            SelectProfile.Visible = true;
            SelectProfile.BringToFront();
            StartPanel.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeTheme();
            if (LastPlayer != null)
            {
                StartNewGame();
                timer1.Stop();
            }
        }
        public void StartNewGame()
        {
            int X = StartButton.Location.X;
            int Y = StartButton.Location.Y + StartButton.Height;
            NewGame = new User_Controls.UserControl_NewGame(LastPlayer);
            this.Controls.Add(NewGame);
            NewGame.BackColor = Color.FromArgb(100, 0, 0, 0);
            NewGame.Location = new Point(X, Y);
            NewGame.UserControl_NewGame_Load(null, null);
            NewGame.Visible = true;
            NewGame.BringToFront();
        }


        //////////////////////////////////Profile Label:
        private void CurrentProfileButton_Click(object sender, EventArgs e)
        {
            CurrentProfiles.UserControl_CurrentProfiles_Load(null, null);
            CurrentProfiles.Visible = true;
            CurrentProfiles.BringToFront();
            ProfilePanel.Visible = false;
        }
        private void NewProfileButton_Click(object sender, EventArgs e)
        {
            NewProfiles.UserControlNewProfiles_Load(null, null);
            NewProfiles.Visible = true;
            NewProfiles.BringToFront();
            ProfilePanel.Visible = false;
        }

        //////////////////////////////////Report Label:
        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            Statistics.UserControlStatistics_Load(null, null);
            Statistics.Visible = true;
            Statistics.BringToFront();
            ReportPanel.Visible = false;
        }
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            History.UserControl_History_Load(null,null);
            History.Visible = true;
            History.BringToFront();
            ReportPanel.Visible = false;
        }

        ////////////////////////////Exit Label:
        private void YESButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MTP mTP = new MTP();
            mTP.Show();
        }
        private void NOButton_Click(object sender, EventArgs e)
        {
            ExitPanel.Visible = false;
        }


        ///////////////////////////////////
        private void ChangeTheme()
        {
            StartButton.BackColor = LastPlayer.colorofbg;
            NewButton.BackColor = LastPlayer.colorofbg;
            ProfileButton.BackColor = LastPlayer.colorofbg;
            CurrentProfileButton.BackColor = LastPlayer.colorofbg;
            NewProfileButton.BackColor = LastPlayer.colorofbg;
            ReportButton.BackColor = LastPlayer.colorofbg;
            HistoryButton.BackColor = LastPlayer.colorofbg;
            StatisticsButton.BackColor = LastPlayer.colorofbg;
            ExitButton.BackColor = LastPlayer.colorofbg;
            YesButton.BackColor = LastPlayer.colorofbg;
            NoButton.BackColor = LastPlayer.colorofbg;
        }










        ///////////////////////////////////
    }
}
