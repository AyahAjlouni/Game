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
    public partial class UserControlNewProfiles : UserControl
    {
        Players new_player = new  Players();
        bool Save=true;
        public UserControlNewProfiles()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SelectName();
            SelectAge();
            SelectGender();
            SelectColor();            
            if(Save == true)
            { 
            Form1.Playerslist.Add(new_player);
            new_player = new Players();
            this.Visible = false;
            this.SendToBack();
            }
            else
            {
                MessageBox.Show("Please Check Your Data !!");
                Save = true;
            }
        }
        private void SelectName()
        {
            if (NameTextBox.Text == "")
            {
                Save = false;
            }
            else
            {
                new_player.Name = NameTextBox.Text;
            }
        }
        private void SelectAge()
        {
            if(comboBox_Age.SelectedItem == null)
            {
                Save = false;
            }
            else
            {
                new_player.Age = int.Parse(comboBox_Age.SelectedItem.ToString());
            }        
        }
        private void SelectGender()
        {
            if (radioButton_Male.Checked)
            {
                new_player.Gender = radioButton_Male.Text;
            }
            else if(radioButton_Female.Checked)
            {
                new_player.Gender = radioButton_Female.Text;
            }
            else
            {
                Save = false;
            }

        }
        private void SelectColor()
        {
            if (radioButton_Blue.Checked)
            {
                new_player.colorofbg = Color.Blue;
            }
            else if (radioButton_Red.Checked)
            {
                new_player.colorofbg = Color.Red;
            }
            else if (radioButton_white.Checked)
            {
                new_player.colorofbg = Color.White;
            }
            else if (radioButton_Black.Checked)
            {
                new_player.colorofbg = Color.Black ;
            }
            else if (radioButton_Green.Checked)
            {
                new_player.colorofbg = Color.Green;
            }
            else if (radioButton_Orange.Checked)
            {
                new_player.colorofbg = Color.Orange;
            }
            else
            {
                new_player.colorofbg = Color.Orange;
            }
        }
        public void UserControlNewProfiles_Load(object sender, EventArgs e)
        {
            CleanControl();
            ChangeTheme();
        }
        private void CleanControl()
        {
            NameTextBox.Text = null;
            radioButton_Male.Checked = false;
            radioButton_Female.Checked = false;
            comboBox_Age.SelectedItem = null;
        }
        private void ChangeTheme()
        {
            BackButton.BackColor = Form1.LastPlayer.colorofbg;
            SaveButton.BackColor = Form1.LastPlayer.colorofbg;
        }

    }
}
