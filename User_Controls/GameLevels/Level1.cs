using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TermProjectCS.User_Controls.GameLevels
{
    public partial class Level1 : UserControl
    {
        Image[] Images = new Image[]
        {
            Properties.Resources.panda,
            Properties.Resources.ladybug
        };
        bool enterstep1 = true;
        bool enterstep2 = true;
        bool enterstep3 = false;
        bool enterstep4 = false;
        public Level1()
        {
            InitializeComponent();
        }
        private void Level1_Load(object sender, EventArgs e)
        {
            assigning();
        }
        private void assigning()
        {
            int[] count = new int[Images.Length];
            Random R = new Random();
            foreach (Control c in this.Controls)
            {
                PictureBox P = c as PictureBox;
                if (P != null)
                {
                    int t = R.Next(0, 2);
                    if (count[t] == 2)
                    {
                        for (int i = 0; i < count.Length; i++)
                        {
                            if (count[i] < 2)
                            {
                                t = i;
                                break;
                            }
                        }
                    }
                    count[t]++;
                    P.Tag = t;
                }
            }
        }
        private void Controling_Tiles(PictureBox pictureBox)
        {
            PictureBox Comparing = null;
            foreach (PictureBox I in this.Controls)
            {
                if (I != null && I != pictureBox)
                {
                    if (I.Enabled   && I.Image!=null)
                    {
                        Comparing = I;
                        break;
                    }
                }
            }
            if (Comparing == null)
            {
                if (pictureBox.Image != null)
                {
                    pictureBox.Image = null;
                }
                else
                {
                    int TagNum = int.Parse(pictureBox.Tag.ToString());
                    pictureBox.Image = Images[TagNum % 2];
                    if (enterstep3)
                        step3(pictureBox);
                    if(enterstep1)
                    step1(pictureBox);
                }
            }
            else
            {
                int TagNum = int.Parse(pictureBox.Tag.ToString());
                pictureBox.Image = Images[TagNum % 2];
                if (pictureBox.Image.Equals(Comparing.Image))
                {
                    pictureBox.Enabled = false;
                    Comparing.Enabled = false;
                    ++UserControl_NewGame.Game.Score;
                    ++UserControl_NewGame.Game.NumOfSuccessfulClicks;
                    UserControl_NewGame.level1++;
                    if (enterstep4)
                        step4(pictureBox);
                    if (enterstep2)
                        step2(pictureBox);
                }
                else
                {
                    MessageBox.Show("Try again");
                    pictureBox.Image = null;
                    Comparing.Image = null;
                    ++UserControl_NewGame.Game.NumOfWrongClicks;
                    if (enterstep4)
                        step4(pictureBox);
                    if (enterstep2)
                        step2(pictureBox);
                }
            }
        }  
        private void pictureBoxs_Click(object sender, EventArgs e)
        {
            Controling_Tiles(sender as PictureBox);
        }
        private void step1(PictureBox pictureBox)
        {
            if (pictureBox.Name == "pictureBox1")
                UserControl_NewGame.Game.steps[0] = "R0C0";
            else if (pictureBox.Name == "pictureBox2")
                UserControl_NewGame.Game.steps[0] = "R0C1";
            else if (pictureBox.Name == "pictureBox3")
                UserControl_NewGame.Game.steps[0] = "R1C0";
            else if (pictureBox.Name == "pictureBox4")
                UserControl_NewGame.Game.steps[0] = "R1C1";
            enterstep1 = false; enterstep3 = true;
        }
        private void step2(PictureBox pictureBox)
        {
            if (pictureBox.Name == "pictureBox1")
                UserControl_NewGame.Game.steps[1] = "R0C0";
            else if (pictureBox.Name == "pictureBox2")
                UserControl_NewGame.Game.steps[1] = "R0C1";
            else if (pictureBox.Name == "pictureBox3")
                UserControl_NewGame.Game.steps[1] = "R1C0";
            else if (pictureBox.Name == "pictureBox4")
                UserControl_NewGame.Game.steps[1] = "R1C1";
            enterstep2 = false;
            enterstep4 = true;

        }
        private void step3(PictureBox pictureBox)
        {
            if (pictureBox.Name == "pictureBox1")
                UserControl_NewGame.Game.steps[2] = "R0C0";
            else if (pictureBox.Name == "pictureBox2")
                UserControl_NewGame.Game.steps[2] = "R0C1";
            else if (pictureBox.Name == "pictureBox3")
                UserControl_NewGame.Game.steps[2] = "R1C0";
            else if (pictureBox.Name == "pictureBox4")
                UserControl_NewGame.Game.steps[2] = "R1C1";
            enterstep3 = false;

        }
        private void step4(PictureBox pictureBox)
        {
            if (pictureBox.Name == "pictureBox1")
                UserControl_NewGame.Game.steps[3] = "R0C0";
            else if (pictureBox.Name == "pictureBox2")
                UserControl_NewGame.Game.steps[3] = "R0C1";
            else if (pictureBox.Name == "pictureBox3")
                UserControl_NewGame.Game.steps[3] = "R1C0";
            else if (pictureBox.Name == "pictureBox4")
                UserControl_NewGame.Game.steps[3] = "R1C1";
            enterstep4 = false;
        }
    }
}
