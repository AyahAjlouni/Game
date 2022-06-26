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
    public partial class UserControl_CurrentProfiles : UserControl
    {
        public UserControl_CurrentProfiles()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.Playerslist.Count; i++)
            {
                if (Form1.Playerslist[i].Name == SelectProfileComboBox.SelectedItem.ToString())
                {
                    YourNameLabel.Text = "Name :" + Form1.Playerslist[i].Name;
                    YourAgeLabel.Text = "Age :" + Form1.Playerslist[i].Age.ToString();
                    YourGenderLabel.Text = "Gender :" + Form1.Playerslist[i].Gender;
                    BackGroundColorLabel.Text = "Background Color :" + Form1.Playerslist[i].colorofbg.ToString();
                }
            }
        }
        public void UserControl_CurrentProfiles_Load(object sender, EventArgs e)
        {
            ChangeTheme();
            FillComboBox();
            CleanControl();
        }
        private void ChangeTheme()
        {
            YourNameLabel.BackColor = Form1.LastPlayer.colorofbg;
            YourGenderLabel.BackColor = Form1.LastPlayer.colorofbg;
            YourAgeLabel.BackColor = Form1.LastPlayer.colorofbg;
            BackGroundColorLabel.BackColor = Form1.LastPlayer.colorofbg;
            BackButton.BackColor = Form1.LastPlayer.colorofbg;
            EnterButton.BackColor = Form1.LastPlayer.colorofbg;
        }
        private void FillComboBox()
        {
            foreach (Players p in Form1.Playerslist)
            {
                SelectProfileComboBox.Items.Add(p.Name);
            }
        }
        private void CleanControl()
        {
            YourNameLabel.Text = "Name :";
            YourAgeLabel.Text = "Age :";
            YourGenderLabel.Text = "Gender :";
            BackGroundColorLabel.Text = "Background Color :";
        }
    }
}
