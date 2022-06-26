namespace TermProjectCS.User_Controls
{
    partial class UserControl_SelectProfile
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
            this.Button_StartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Profiles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_StartGame
            // 
            this.Button_StartGame.BackColor = System.Drawing.Color.Orange;
            this.Button_StartGame.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_StartGame.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_StartGame.Location = new System.Drawing.Point(144, 284);
            this.Button_StartGame.Name = "Button_StartGame";
            this.Button_StartGame.Size = new System.Drawing.Size(429, 56);
            this.Button_StartGame.TabIndex = 0;
            this.Button_StartGame.Text = "Start The game";
            this.Button_StartGame.UseVisualStyleBackColor = false;
            this.Button_StartGame.Click += new System.EventHandler(this.Button_StartGame_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(294, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Game ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Profiles
            // 
            this.comboBox_Profiles.Font = new System.Drawing.Font("Lemon", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Profiles.FormattingEnabled = true;
            this.comboBox_Profiles.Location = new System.Drawing.Point(294, 157);
            this.comboBox_Profiles.Name = "comboBox_Profiles";
            this.comboBox_Profiles.Size = new System.Drawing.Size(279, 34);
            this.comboBox_Profiles.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(144, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profile :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.Orange;
            this.Button_Back.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Back.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Back.Location = new System.Drawing.Point(624, 422);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(124, 50);
            this.Button_Back.TabIndex = 0;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // UserControl_SelectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.comboBox_Profiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_StartGame);
            this.Name = "UserControl_SelectProfile";
            this.Size = new System.Drawing.Size(763, 487);
            this.Load += new System.EventHandler(this.UserControl_SelectProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_StartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.ComboBox comboBox_Profiles;
    }
}
