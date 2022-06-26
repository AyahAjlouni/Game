namespace TermProjectCS.User_Controls
{
    partial class UserControl_NewGame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_NewGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_level = new System.Windows.Forms.Label();
            this.Label_NumOfSuccessful = new System.Windows.Forms.Label();
            this.Label_NumOFWrong = new System.Windows.Forms.Label();
            this.Label_Score = new System.Windows.Forms.Label();
            this.Label_Duration = new System.Windows.Forms.Label();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_ExitGame = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ExitGame)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(201, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MTP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lemon", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(201, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "MTP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Label_level);
            this.panel2.Controls.Add(this.Label_NumOfSuccessful);
            this.panel2.Controls.Add(this.Label_NumOFWrong);
            this.panel2.Controls.Add(this.Label_Score);
            this.panel2.Controls.Add(this.Label_Duration);
            this.panel2.Controls.Add(this.Label_UserName);
            this.panel2.Location = new System.Drawing.Point(12, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 68);
            this.panel2.TabIndex = 1;
            // 
            // Label_level
            // 
            this.Label_level.BackColor = System.Drawing.Color.Transparent;
            this.Label_level.Font = new System.Drawing.Font("Lemon", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_level.ForeColor = System.Drawing.Color.Orange;
            this.Label_level.Location = new System.Drawing.Point(16, 39);
            this.Label_level.Name = "Label_level";
            this.Label_level.Size = new System.Drawing.Size(123, 20);
            this.Label_level.TabIndex = 0;
            this.Label_level.Text = "Level :";
            this.Label_level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_NumOfSuccessful
            // 
            this.Label_NumOfSuccessful.BackColor = System.Drawing.Color.Transparent;
            this.Label_NumOfSuccessful.Font = new System.Drawing.Font("Lemon", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_NumOfSuccessful.ForeColor = System.Drawing.Color.Orange;
            this.Label_NumOfSuccessful.Location = new System.Drawing.Point(396, 10);
            this.Label_NumOfSuccessful.Name = "Label_NumOfSuccessful";
            this.Label_NumOfSuccessful.Size = new System.Drawing.Size(344, 20);
            this.Label_NumOfSuccessful.TabIndex = 0;
            this.Label_NumOfSuccessful.Text = "Numbers Of successful clicks :";
            this.Label_NumOfSuccessful.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_NumOFWrong
            // 
            this.Label_NumOFWrong.BackColor = System.Drawing.Color.Transparent;
            this.Label_NumOFWrong.Font = new System.Drawing.Font("Lemon", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_NumOFWrong.ForeColor = System.Drawing.Color.Orange;
            this.Label_NumOFWrong.Location = new System.Drawing.Point(436, 39);
            this.Label_NumOFWrong.Name = "Label_NumOFWrong";
            this.Label_NumOFWrong.Size = new System.Drawing.Size(304, 20);
            this.Label_NumOFWrong.TabIndex = 0;
            this.Label_NumOFWrong.Text = "Numbers Of wrong clicks :";
            this.Label_NumOFWrong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Score
            // 
            this.Label_Score.BackColor = System.Drawing.Color.Transparent;
            this.Label_Score.Font = new System.Drawing.Font("Lemon", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Score.ForeColor = System.Drawing.Color.Orange;
            this.Label_Score.Location = new System.Drawing.Point(221, 10);
            this.Label_Score.Name = "Label_Score";
            this.Label_Score.Size = new System.Drawing.Size(116, 20);
            this.Label_Score.TabIndex = 0;
            this.Label_Score.Text = "Scores :";
            this.Label_Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Duration
            // 
            this.Label_Duration.BackColor = System.Drawing.Color.Transparent;
            this.Label_Duration.Font = new System.Drawing.Font("Lemon", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Duration.ForeColor = System.Drawing.Color.Orange;
            this.Label_Duration.Location = new System.Drawing.Point(145, 39);
            this.Label_Duration.Name = "Label_Duration";
            this.Label_Duration.Size = new System.Drawing.Size(294, 20);
            this.Label_Duration.TabIndex = 0;
            this.Label_Duration.Text = "Duration(Seconds) :";
            this.Label_Duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_UserName
            // 
            this.Label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.Label_UserName.Font = new System.Drawing.Font("Lemon", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_UserName.ForeColor = System.Drawing.Color.Orange;
            this.Label_UserName.Location = new System.Drawing.Point(16, 10);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(188, 20);
            this.Label_UserName.TabIndex = 0;
            this.Label_UserName.Text = "User name :";
            this.Label_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Duration
            // 
            this.Duration.Tick += new System.EventHandler(this.Duration_Tick);
            // 
            // pictureBox_ExitGame
            // 
            this.pictureBox_ExitGame.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ExitGame.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ExitGame.Image")));
            this.pictureBox_ExitGame.Location = new System.Drawing.Point(723, 15);
            this.pictureBox_ExitGame.Name = "pictureBox_ExitGame";
            this.pictureBox_ExitGame.Size = new System.Drawing.Size(31, 31);
            this.pictureBox_ExitGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ExitGame.TabIndex = 3;
            this.pictureBox_ExitGame.TabStop = false;
            this.pictureBox_ExitGame.Click += new System.EventHandler(this.pictureBox_ExitGame_Click);
            // 
            // UserControl_NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pictureBox_ExitGame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_NewGame";
            this.Size = new System.Drawing.Size(763, 487);
            this.Load += new System.EventHandler(this.UserControl_NewGame_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ExitGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.Label Labellevel;
        private System.Windows.Forms.Label Label_NumOfSuccessful;
        private System.Windows.Forms.Label Label_NumOFWrong;
        private System.Windows.Forms.Label Label_Score;
        private System.Windows.Forms.Label Label_Duration;
        public  System.Windows.Forms.Timer Duration;
        private System.Windows.Forms.PictureBox pictureBox_ExitGame;
        private System.Windows.Forms.Label Label_level;
    }
}
