using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TermProjectCS.User_Controls.GameLevels
{
    public partial class Level5 : UserControl
    {
        Image[] Images = new Image[]
        {
            Properties.Resources.c1,
            Properties.Resources.c2,
            Properties.Resources.c3,
            Properties.Resources.c4,
            Properties.Resources.c5,
            Properties.Resources.c6,
            Properties.Resources.c7,
            Properties.Resources.c8,
            Properties.Resources.c9,
            Properties.Resources.c10,
            Properties.Resources.c11,
            Properties.Resources.c12,
            Properties.Resources.c13,
            Properties.Resources.c14,
            Properties.Resources.c15,
            Properties.Resources.c16,
            Properties.Resources.c17,
            Properties.Resources.c18
        };
        public Level5()
        {
            InitializeComponent();
        }
        private void Level5_Load(object sender, EventArgs e)
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
                    pictureBox.Image = Images[TagNum % 18];
                }
            }
            else
            {
                int TagNum = int.Parse(pictureBox.Tag.ToString());
                pictureBox.Image = Images[TagNum % 18];
                if (pictureBox.Image.Equals(Comparing.Image))
                {
                    pictureBox.Enabled = false;
                    Comparing.Enabled = false;
                    UserControl_NewGame.Game.Score++;
                    UserControl_NewGame.Game.NumOfSuccessfulClicks++;
                    UserControl_NewGame.level5++;
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
