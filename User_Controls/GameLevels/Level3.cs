using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TermProjectCS.User_Controls.GameLevels
{
    public partial class Level3 : UserControl
    {
        Image[] Images = new Image[]{
            Properties.Resources.cool,
            Properties.Resources.angry,
            Properties.Resources.in_love,
            Properties.Resources.sad,
            Properties.Resources.shocked,
            Properties.Resources.smile,
            Properties.Resources.smiling,
            Properties.Resources.wink
        };
        public Level3()
        {
            InitializeComponent();
        }
        private void Level3_Load(object sender, EventArgs e)
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
                    int t = R.Next(0, Images.Length);

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
            foreach (Control I in this.Controls)
            {
                PictureBox P = I as PictureBox;

                if (P != null && P != pictureBox)
                {
                    if (P.Enabled && P.Image != null)
                    {
                        Comparing = P;
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
                    pictureBox.Image = Images[TagNum % 8];
                }
            }
            else
            {
                int TagNum = int.Parse(pictureBox.Tag.ToString());
                pictureBox.Image = Images[TagNum % 8];
                if (pictureBox.Image.Equals(Comparing.Image))
                {
                    pictureBox.Enabled = false;
                    Comparing.Enabled = false;
                    UserControl_NewGame.Game.Score++;
                    UserControl_NewGame.Game.NumOfSuccessfulClicks++;
                    UserControl_NewGame.level3++;
                }
                else
                {
                    MessageBox.Show("Try again");
                    pictureBox.Image = null;
                    Comparing.Image = null;
                    UserControl_NewGame.Game.NumOfWrongClicks++;
                }
            }
        }
        private void pictureBoxs_Click(object sender, EventArgs e)
        {
            Controling_Tiles(sender as PictureBox);

        }
    }
}
