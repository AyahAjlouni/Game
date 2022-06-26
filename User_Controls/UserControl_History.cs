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
    public partial class UserControl_History : UserControl
    {
        public UserControl_History()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        public void UserControl_History_Load(object sender, EventArgs e)
        {
            Changetheme();
            ChangeLastPlayer();
            ChangeSteps();
            ChangePenultimatePlayer();
        }
        private void ChangeLastPlayer()
        {
            if (Form1.LastPlayer.G.Count != 0)
            {
                Label_Profile.Text = Form1.LastPlayer.Name;
                Label_Duration.Text = Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].Duration.ToString();
                Label_Levels.Text = Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].Level.ToString();
                Label_Score.Text = Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].Score.ToString();
                Label_Date.Text = Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].date.ToShortDateString().ToString();
            }
        }
        private void ChangePenultimatePlayer()
        {
            if (Form1.PenultimatePlayer.G.Count != 0)
            {
                Label_Profile2.Text = Form1.PenultimatePlayer.Name;
                Label_Duration2.Text = Form1.PenultimatePlayer.G[Form1.PenultimatePlayer.G.Count - 1].Duration.ToString();
                Label_Levels2.Text = Form1.PenultimatePlayer.G[Form1.PenultimatePlayer.G.Count - 1].Level.ToString();
                Label_Score2.Text = Form1.PenultimatePlayer.G[Form1.PenultimatePlayer.G.Count - 1].Score.ToString();
                Label_Date2.Text = Form1.PenultimatePlayer.G[Form1.PenultimatePlayer.G.Count - 1].date.ToShortDateString().ToString();
            }

        }
        private void Changetheme()
        {
            label1.ForeColor = Form1.LastPlayer.colorofbg;
            label2.ForeColor = Form1.LastPlayer.colorofbg;
            label3.ForeColor = Form1.LastPlayer.colorofbg;
            label4.ForeColor = Form1.LastPlayer.colorofbg;
            label5.ForeColor = Form1.LastPlayer.colorofbg;
            label6.ForeColor = Form1.LastPlayer.colorofbg;
            label7.ForeColor = Form1.LastPlayer.colorofbg;
            label13.ForeColor = Form1.LastPlayer.colorofbg;
            label11.ForeColor = Form1.LastPlayer.colorofbg;
            label9.ForeColor = Form1.LastPlayer.colorofbg;
            label8.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Step1.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Step2.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Step3.ForeColor = Form1.LastPlayer.colorofbg;
            Label_step4.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Profile.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Profile2.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Date.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Date2.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Duration.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Duration2.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Levels.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Levels2.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Score.ForeColor = Form1.LastPlayer.colorofbg;
            Label_Score2.ForeColor = Form1.LastPlayer.colorofbg;
            BackButton.BackColor = Form1.LastPlayer.colorofbg;

        }
        private void ChangeSteps()
        {
            if (Form1.LastPlayer.G.Count != 0)
            {
                if (Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].steps[0] == null)
                    Label_Step1.Text = "0";
                else
                    Label_Step1.Text = Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].steps[0].ToString();
                if (Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].steps[1] == null)
                    Label_Step1.Text = "0";
                else
                    Label_Step2.Text = Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].steps[1].ToString();
                if (Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].steps[2] == null)
                    Label_Step1.Text = "0";
                else
                    Label_Step3.Text = Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].steps[2].ToString();
                if (Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].steps[3] == null)
                    Label_Step1.Text = "0";
                else
                    Label_step4.Text = Form1.LastPlayer.G[Form1.LastPlayer.G.Count - 1].steps[3].ToString();
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            Form1.timer1.Start();
        }
    }
}
