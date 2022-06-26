using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TermProjectCS
{
    public partial class MTP : Form
    {
        int i = 0;
        public MTP()
        {
            InitializeComponent();
        }

        private void MTP_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 3)
            {
                this.Close();
                Application.Exit();
            }
                
        }
    }
}
