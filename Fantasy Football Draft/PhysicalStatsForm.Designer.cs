namespace Fantasy_Football_Draft
{
    partial class PhysicalStatsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.playerHeightLabel = new System.Windows.Forms.Label();
            this.playerHeight = new System.Windows.Forms.Label();
            this.playerWeightLabel = new System.Windows.Forms.Label();
            this.playerWeight = new System.Windows.Forms.Label();
            this.playerBloodTypeLabel = new System.Windows.Forms.Label();
            this.playerBloodType = new System.Windows.Forms.Label();
            this.playerEyeColorLabel = new System.Windows.Forms.Label();
            this.playerEyeColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(15, 9);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(39, 13);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player:";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(92, 9);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(0, 13);
            this.playerName.TabIndex = 1;
            // 
            // playerHeightLabel
            // 
            this.playerHeightLabel.AutoSize = true;
            this.playerHeightLabel.Location = new System.Drawing.Point(15, 42);
            this.playerHeightLabel.Name = "playerHeightLabel";
            this.playerHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.playerHeightLabel.TabIndex = 2;
            this.playerHeightLabel.Text = "Height:";
            // 
            // playerHeight
            // 
            this.playerHeight.AutoSize = true;
            this.playerHeight.Location = new System.Drawing.Point(92, 42);
            this.playerHeight.Name = "playerHeight";
            this.playerHeight.Size = new System.Drawing.Size(66, 13);
            this.playerHeight.TabIndex = 3;
            this.playerHeight.Text = "playerHeight";
            // 
            // playerWeightLabel
            // 
            this.playerWeightLabel.AutoSize = true;
            this.playerWeightLabel.Location = new System.Drawing.Point(15, 80);
            this.playerWeightLabel.Name = "playerWeightLabel";
            this.playerWeightLabel.Size = new System.Drawing.Size(44, 13);
            this.playerWeightLabel.TabIndex = 4;
            this.playerWeightLabel.Text = "Weight:";
            // 
            // playerWeight
            // 
            this.playerWeight.AutoSize = true;
            this.playerWeight.Location = new System.Drawing.Point(92, 80);
            this.playerWeight.Name = "playerWeight";
            this.playerWeight.Size = new System.Drawing.Size(69, 13);
            this.playerWeight.TabIndex = 5;
            this.playerWeight.Text = "playerWeight";
            // 
            // playerBloodTypeLabel
            // 
            this.playerBloodTypeLabel.AutoSize = true;
            this.playerBloodTypeLabel.Location = new System.Drawing.Point(15, 118);
            this.playerBloodTypeLabel.Name = "playerBloodTypeLabel";
            this.playerBloodTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.playerBloodTypeLabel.TabIndex = 6;
            this.playerBloodTypeLabel.Text = "Blood Type:";
            // 
            // playerBloodType
            // 
            this.playerBloodType.AutoSize = true;
            this.playerBloodType.Location = new System.Drawing.Point(92, 118);
            this.playerBloodType.Name = "playerBloodType";
            this.playerBloodType.Size = new System.Drawing.Size(86, 13);
            this.playerBloodType.TabIndex = 7;
            this.playerBloodType.Text = "playerBloodType";
            // 
            // playerEyeColorLabel
            // 
            this.playerEyeColorLabel.AutoSize = true;
            this.playerEyeColorLabel.Location = new System.Drawing.Point(15, 157);
            this.playerEyeColorLabel.Name = "playerEyeColorLabel";
            this.playerEyeColorLabel.Size = new System.Drawing.Size(55, 13);
            this.playerEyeColorLabel.TabIndex = 8;
            this.playerEyeColorLabel.Text = "Eye Color:";
            // 
            // playerEyeColor
            // 
            this.playerEyeColor.AutoSize = true;
            this.playerEyeColor.Location = new System.Drawing.Point(92, 157);
            this.playerEyeColor.Name = "playerEyeColor";
            this.playerEyeColor.Size = new System.Drawing.Size(77, 13);
            this.playerEyeColor.TabIndex = 9;
            this.playerEyeColor.Text = "playerEyeColor";
            // 
            // PhysicalStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 191);
            this.Controls.Add(this.playerEyeColor);
            this.Controls.Add(this.playerEyeColorLabel);
            this.Controls.Add(this.playerBloodType);
            this.Controls.Add(this.playerBloodTypeLabel);
            this.Controls.Add(this.playerWeight);
            this.Controls.Add(this.playerWeightLabel);
            this.Controls.Add(this.playerHeight);
            this.Controls.Add(this.playerHeightLabel);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.playerNameLabel);
            this.Name = "PhysicalStatsForm";
            this.Text = "Physical Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label playerHeightLabel;
        private System.Windows.Forms.Label playerHeight;
        private System.Windows.Forms.Label playerWeightLabel;
        private System.Windows.Forms.Label playerWeight;
        private System.Windows.Forms.Label playerBloodTypeLabel;
        private System.Windows.Forms.Label playerBloodType;
        private System.Windows.Forms.Label playerEyeColorLabel;
        private System.Windows.Forms.Label playerEyeColor;
    }
}