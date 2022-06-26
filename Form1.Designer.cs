namespace TermProjectCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.NewButton = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.NewProfileButton = new System.Windows.Forms.Button();
            this.CurrentProfileButton = new System.Windows.Forms.Button();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartPanel.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.ReportPanel.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Orange;
            this.StartButton.Font = new System.Drawing.Font("Lemon", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StartButton.Location = new System.Drawing.Point(12, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartButton.Size = new System.Drawing.Size(166, 55);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start ";
            this.StartButton.UseMnemonic = false;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Orange;
            this.ProfileButton.Font = new System.Drawing.Font("Lemon", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfileButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ProfileButton.Location = new System.Drawing.Point(217, 12);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProfileButton.Size = new System.Drawing.Size(166, 55);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseMnemonic = false;
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.Orange;
            this.ReportButton.Font = new System.Drawing.Font("Lemon", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReportButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ReportButton.Location = new System.Drawing.Point(417, 12);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReportButton.Size = new System.Drawing.Size(166, 55);
            this.ReportButton.TabIndex = 0;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseMnemonic = false;
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Orange;
            this.ExitButton.Font = new System.Drawing.Font("Lemon", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExitButton.Location = new System.Drawing.Point(610, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExitButton.Size = new System.Drawing.Size(166, 55);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseMnemonic = false;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.AllowDrop = true;
            this.StartPanel.BackColor = System.Drawing.Color.Transparent;
            this.StartPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartPanel.Controls.Add(this.NewButton);
            this.StartPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StartPanel.Location = new System.Drawing.Point(12, 67);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(166, 270);
            this.StartPanel.TabIndex = 1;
            this.StartPanel.Visible = false;
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.Orange;
            this.NewButton.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NewButton.Location = new System.Drawing.Point(0, 1);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(166, 47);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "new";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.AllowDrop = true;
            this.ProfilePanel.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilePanel.Controls.Add(this.NewProfileButton);
            this.ProfilePanel.Controls.Add(this.CurrentProfileButton);
            this.ProfilePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProfilePanel.Location = new System.Drawing.Point(217, 67);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(166, 270);
            this.ProfilePanel.TabIndex = 1;
            this.ProfilePanel.Visible = false;
            // 
            // NewProfileButton
            // 
            this.NewProfileButton.BackColor = System.Drawing.Color.Orange;
            this.NewProfileButton.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewProfileButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NewProfileButton.Location = new System.Drawing.Point(0, 44);
            this.NewProfileButton.Name = "NewProfileButton";
            this.NewProfileButton.Size = new System.Drawing.Size(166, 47);
            this.NewProfileButton.TabIndex = 0;
            this.NewProfileButton.Text = "New";
            this.NewProfileButton.UseVisualStyleBackColor = false;
            this.NewProfileButton.Click += new System.EventHandler(this.NewProfileButton_Click);
            // 
            // CurrentProfileButton
            // 
            this.CurrentProfileButton.BackColor = System.Drawing.Color.Orange;
            this.CurrentProfileButton.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentProfileButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CurrentProfileButton.Location = new System.Drawing.Point(0, 1);
            this.CurrentProfileButton.Name = "CurrentProfileButton";
            this.CurrentProfileButton.Size = new System.Drawing.Size(166, 47);
            this.CurrentProfileButton.TabIndex = 0;
            this.CurrentProfileButton.Text = "Current";
            this.CurrentProfileButton.UseVisualStyleBackColor = false;
            this.CurrentProfileButton.Click += new System.EventHandler(this.CurrentProfileButton_Click);
            // 
            // ReportPanel
            // 
            this.ReportPanel.AllowDrop = true;
            this.ReportPanel.BackColor = System.Drawing.Color.Transparent;
            this.ReportPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportPanel.Controls.Add(this.HistoryButton);
            this.ReportPanel.Controls.Add(this.StatisticsButton);
            this.ReportPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ReportPanel.Location = new System.Drawing.Point(417, 67);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(166, 270);
            this.ReportPanel.TabIndex = 1;
            this.ReportPanel.Visible = false;
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.Orange;
            this.HistoryButton.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HistoryButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HistoryButton.Location = new System.Drawing.Point(0, 44);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(167, 47);
            this.HistoryButton.TabIndex = 0;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.BackColor = System.Drawing.Color.Orange;
            this.StatisticsButton.Font = new System.Drawing.Font("Lemon", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatisticsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StatisticsButton.Location = new System.Drawing.Point(0, 2);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(166, 47);
            this.StatisticsButton.TabIndex = 0;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = false;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // ExitPanel
            // 
            this.ExitPanel.AllowDrop = true;
            this.ExitPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExitPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPanel.Controls.Add(this.NoButton);
            this.ExitPanel.Controls.Add(this.YesButton);
            this.ExitPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ExitPanel.Location = new System.Drawing.Point(610, 67);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(166, 270);
            this.ExitPanel.TabIndex = 1;
            this.ExitPanel.Visible = false;
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.Orange;
            this.NoButton.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NoButton.Location = new System.Drawing.Point(0, 44);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(166, 47);
            this.NoButton.TabIndex = 0;
            this.NoButton.Text = "NO";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NOButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.Orange;
            this.YesButton.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YesButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.YesButton.Location = new System.Drawing.Point(0, 0);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(166, 47);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "YES";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YESButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.ExitPanel);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(816, 600);
            this.MinimumSize = new System.Drawing.Size(816, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MTP Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StartPanel.ResumeLayout(false);
            this.ProfilePanel.ResumeLayout(false);
            this.ReportPanel.ResumeLayout(false);
            this.ExitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.Panel ExitPanel;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button NewProfileButton;
        private System.Windows.Forms.Button CurrentProfileButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

