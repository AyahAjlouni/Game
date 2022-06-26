using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TermProjectCS.User_Controls.GameLevels
{
    public partial class Level4 : UserControl
    {
        Image[] Images = new Image[]
        {
            Properties.Resources.f1,
            Properties.Resources.f2,
            Properties.Resources.f3,
            Properties.Resources.f4,
            Properties.Resources.f5,
            Properties.Resources.f6,
            Properties.Resources.f7,
            Properties.Resources.f8,
            Properties.Resources.f9,
            Properties.Resources.f10,
            Properties.Resources.f11,
            Properties.Resources.f12
        };
        public Level4()
        {
            InitializeComponent();
        }
        private void Level4_Load(object sender, EventArgs e)
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
                    pictureBox.Image = Images[TagNum % 12];
                }
            }
            else
            {
                int TagNum = int.Parse(pictureBox.Tag.ToString());
                pictureBox.Image = Images[TagNum % 12];
                if (pictureBox.Image.Equals(Comparing.Image))
                {
                    pictureBox.Enabled = false;
                    Comparing.Enabled = false;
                    UserControl_NewGame.Game.Score++;
                    UserControl_NewGame.Game.NumOfSuccessfulClicks++;
                    UserControl_NewGame.level4++;
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
