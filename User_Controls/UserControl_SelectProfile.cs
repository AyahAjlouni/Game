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
    public partial class UserControl_SelectProfile : UserControl
    {
        public UserControl_SelectProfile()
        {
            InitializeComponent();
        }
        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }  
        private void Button_StartGame_Click(object sender, EventArgs e)
        {
            if(Form1.Playerslist.Count == 0)
            {
                MessageBox.Show("Please Create an Account!");
                this.Visible = false;
            }
            else if(comboBox_Profiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a profile");
            }
            else
            {
                for (int i = 0; i < Form1.Playerslist.Count; i++)
                {
                    if (Form1.Playerslist[i].Name ==  comboBox_Profiles.SelectedItem.ToString() )
                    {
                        Form1.LastPlayer = Form1.Playerslist[i];
                    }
                }
                this.Visible = false;
                Form1.timer1.Start();
            }
        }
        public void UserControl_SelectProfile_Load(object sender, EventArgs e)
        {
            ChangeTheme();
            FillComboBox();
            CleanControl();
        }
        private void ChangeTheme()
        {
            label1.ForeColor = Form1.LastPlayer.colorofbg;
            label2.ForeColor = Form1.LastPlayer.colorofbg;
            Button_StartGame.BackColor = Form1.LastPlayer.colorofbg;
            Button_Back.BackColor = Form1.LastPlayer.colorofbg;
        }
        private void FillComboBox()
        {
            comboBox_Profiles.Items.Clear();
            foreach(Players p in Form1.Playerslist)
            {
                comboBox_Profiles.Items.Add(p.Name);
            }
        }
        private void CleanControl()
        {
            comboBox_Profiles.Text = null;
        }
    }
}
