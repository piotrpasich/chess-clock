namespace ChessClock
{
    partial class GameController
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
            if (disposing && (components != null)) {
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
            this.Player1TimeLabel = new System.Windows.Forms.Label();
            this.Player2TimeLabel = new System.Windows.Forms.Label();
            this.SwitchPlayerButton = new System.Windows.Forms.Button();
            this.WhiteLabel = new System.Windows.Forms.Label();
            this.BlackLabel = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1TimeLabel
            // 
            this.Player1TimeLabel.AutoSize = true;
            this.Player1TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player1TimeLabel.Location = new System.Drawing.Point(16, 52);
            this.Player1TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1TimeLabel.Name = "Player1TimeLabel";
            this.Player1TimeLabel.Size = new System.Drawing.Size(284, 73);
            this.Player1TimeLabel.TabIndex = 0;
            this.Player1TimeLabel.Text = "00:00:00";
            this.Player1TimeLabel.Click += new System.EventHandler(this.Player1TimeLabel_Click);
            // 
            // Player2TimeLabel
            // 
            this.Player2TimeLabel.AutoSize = true;
            this.Player2TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player2TimeLabel.Location = new System.Drawing.Point(320, 52);
            this.Player2TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2TimeLabel.Name = "Player2TimeLabel";
            this.Player2TimeLabel.Size = new System.Drawing.Size(284, 73);
            this.Player2TimeLabel.TabIndex = 1;
            this.Player2TimeLabel.Text = "00:00:00";
            this.Player2TimeLabel.Click += new System.EventHandler(this.Player2TimeLabel_Click);
            // 
            // SwitchPlayerButton
            // 
            this.SwitchPlayerButton.Location = new System.Drawing.Point(197, 142);
            this.SwitchPlayerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SwitchPlayerButton.Name = "SwitchPlayerButton";
            this.SwitchPlayerButton.Size = new System.Drawing.Size(191, 63);
            this.SwitchPlayerButton.TabIndex = 2;
            this.SwitchPlayerButton.Text = "Switch";
            this.SwitchPlayerButton.UseVisualStyleBackColor = true;
            this.SwitchPlayerButton.Click += new System.EventHandler(this.SwitchPlayerButton_Click);
            // 
            // WhiteLabel
            // 
            this.WhiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WhiteLabel.Location = new System.Drawing.Point(28, 20);
            this.WhiteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WhiteLabel.Name = "WhiteLabel";
            this.WhiteLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WhiteLabel.Size = new System.Drawing.Size(232, 32);
            this.WhiteLabel.TabIndex = 3;
            this.WhiteLabel.Text = "White";
            this.WhiteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BlackLabel
            // 
            this.BlackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlackLabel.Location = new System.Drawing.Point(332, 20);
            this.BlackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BlackLabel.Name = "BlackLabel";
            this.BlackLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlackLabel.Size = new System.Drawing.Size(235, 32);
            this.BlackLabel.TabIndex = 4;
            this.BlackLabel.Text = "Black";
            this.BlackLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BlackLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartStopButton
            // 
            this.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartStopButton.Location = new System.Drawing.Point(485, 177);
            this.StartStopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(46, 28);
            this.StartStopButton.TabIndex = 5;
            this.StartStopButton.Text = "Stop";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WinnerLabel.Location = new System.Drawing.Point(9, 136);
            this.WinnerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(582, 74);
            this.WinnerLabel.TabIndex = 6;
            this.WinnerLabel.Text = "Winner";
            this.WinnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinnerLabel.Click += new System.EventHandler(this.WinnerLabel_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Location = new System.Drawing.Point(543, 177);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(46, 28);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GameController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 239);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.BlackLabel);
            this.Controls.Add(this.WhiteLabel);
            this.Controls.Add(this.SwitchPlayerButton);
            this.Controls.Add(this.Player2TimeLabel);
            this.Controls.Add(this.Player1TimeLabel);
            this.Controls.Add(this.WinnerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameController";
            this.Text = "Chess Game";
            this.Load += new System.EventHandler(this.GameController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player1TimeLabel;
        private System.Windows.Forms.Label Player2TimeLabel;
        private System.Windows.Forms.Button SwitchPlayerButton;
        private System.Windows.Forms.Label WhiteLabel;
        private System.Windows.Forms.Label BlackLabel;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Button ResetButton;
    }
}