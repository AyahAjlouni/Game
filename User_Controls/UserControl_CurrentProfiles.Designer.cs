namespace TermProjectCS.User_Controls
{
    partial class UserControl_CurrentProfiles
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackGroundColorLabel = new System.Windows.Forms.Label();
            this.YourAgeLabel = new System.Windows.Forms.Label();
            this.YourGenderLabel = new System.Windows.Forms.Label();
            this.YourNameLabel = new System.Windows.Forms.Label();
            this.SelectProfileComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Orange;
            this.EnterButton.Font = new System.Drawing.Font("Lemon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EnterButton.Location = new System.Drawing.Point(640, 429);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(109, 36);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Orange;
            this.BackButton.Font = new System.Drawing.Font("Lemon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(14, 429);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(109, 36);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackGroundColorLabel
            // 
            this.BackGroundColorLabel.BackColor = System.Drawing.Color.Orange;
            this.BackGroundColorLabel.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackGroundColorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BackGroundColorLabel.Location = new System.Drawing.Point(398, 256);
            this.BackGroundColorLabel.Name = "BackGroundColorLabel";
            this.BackGroundColorLabel.Size = new System.Drawing.Size(313, 67);
            this.BackGroundColorLabel.TabIndex = 1;
            this.BackGroundColorLabel.Text = "Background Color";
            this.BackGroundColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YourAgeLabel
            // 
            this.YourAgeLabel.BackColor = System.Drawing.Color.Orange;
            this.YourAgeLabel.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourAgeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.YourAgeLabel.Location = new System.Drawing.Point(398, 184);
            this.YourAgeLabel.Name = "YourAgeLabel";
            this.YourAgeLabel.Size = new System.Drawing.Size(313, 67);
            this.YourAgeLabel.TabIndex = 1;
            this.YourAgeLabel.Text = "Your Age";
            this.YourAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YourGenderLabel
            // 
            this.YourGenderLabel.BackColor = System.Drawing.Color.Orange;
            this.YourGenderLabel.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourGenderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.YourGenderLabel.Location = new System.Drawing.Point(398, 110);
            this.YourGenderLabel.Name = "YourGenderLabel";
            this.YourGenderLabel.Size = new System.Drawing.Size(313, 67);
            this.YourGenderLabel.TabIndex = 1;
            this.YourGenderLabel.Text = "Your Gender";
            this.YourGenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YourNameLabel
            // 
            this.YourNameLabel.BackColor = System.Drawing.Color.Orange;
            this.YourNameLabel.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.YourNameLabel.Location = new System.Drawing.Point(398, 31);
            this.YourNameLabel.Name = "YourNameLabel";
            this.YourNameLabel.Size = new System.Drawing.Size(313, 67);
            this.YourNameLabel.TabIndex = 1;
            this.YourNameLabel.Text = "Your name.";
            this.YourNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectProfileComboBox
            // 
            this.SelectProfileComboBox.BackColor = System.Drawing.Color.White;
            this.SelectProfileComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SelectProfileComboBox.Font = new System.Drawing.Font("Lemon", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectProfileComboBox.FormattingEnabled = true;
            this.SelectProfileComboBox.Location = new System.Drawing.Point(46, 31);
            this.SelectProfileComboBox.Name = "SelectProfileComboBox";
            this.SelectProfileComboBox.Size = new System.Drawing.Size(191, 32);
            this.SelectProfileComboBox.TabIndex = 0;
            // 
            // UserControl_CurrentProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.SelectProfileComboBox);
            this.Controls.Add(this.YourNameLabel);
            this.Controls.Add(this.YourGenderLabel);
            this.Controls.Add(this.YourAgeLabel);
            this.Controls.Add(this.BackGroundColorLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EnterButton);
            this.Name = "UserControl_CurrentProfiles";
            this.Size = new System.Drawing.Size(763, 477);
            this.Load += new System.EventHandler(this.UserControl_CurrentProfiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label BackGroundColorLabel;
        private System.Windows.Forms.Label YourAgeLabel;
        private System.Windows.Forms.Label YourGenderLabel;
        private System.Windows.Forms.Label YourNameLabel;
        public System.Windows.Forms.ComboBox SelectProfileComboBox;
    }
}
