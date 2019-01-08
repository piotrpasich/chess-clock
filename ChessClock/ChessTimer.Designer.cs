namespace ChessClock
{
    partial class ChessTimer
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Player2TimeInput = new System.Windows.Forms.NumericUpDown();
            this.Player1TimeInput = new System.Windows.Forms.NumericUpDown();
            this.TimeAddedAfterEveryRoundInput = new System.Windows.Forms.NumericUpDown();
            this.StartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartingPlayer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player2TimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1TimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeAddedAfterEveryRoundInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Player2TimeInput
            // 
            this.Player2TimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player2TimeInput.Location = new System.Drawing.Point(270, 78);
            this.Player2TimeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player2TimeInput.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.Player2TimeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Player2TimeInput.Name = "Player2TimeInput";
            this.Player2TimeInput.Size = new System.Drawing.Size(75, 41);
            this.Player2TimeInput.TabIndex = 0;
            this.Player2TimeInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Player1TimeInput
            // 
            this.Player1TimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player1TimeInput.Location = new System.Drawing.Point(100, 78);
            this.Player1TimeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player1TimeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Player1TimeInput.Name = "Player1TimeInput";
            this.Player1TimeInput.Size = new System.Drawing.Size(69, 41);
            this.Player1TimeInput.TabIndex = 1;
            this.Player1TimeInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // TimeAddedAfterEveryRoundInput
            // 
            this.TimeAddedAfterEveryRoundInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeAddedAfterEveryRoundInput.Location = new System.Drawing.Point(100, 134);
            this.TimeAddedAfterEveryRoundInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeAddedAfterEveryRoundInput.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.TimeAddedAfterEveryRoundInput.Name = "TimeAddedAfterEveryRoundInput";
            this.TimeAddedAfterEveryRoundInput.Size = new System.Drawing.Size(75, 41);
            this.TimeAddedAfterEveryRoundInput.TabIndex = 2;
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(389, 207);
            this.StartGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(104, 33);
            this.StartGame.TabIndex = 3;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "White";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(200, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Black";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(200, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "seconds after every move";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(488, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Please enter time in minutes for players";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(479, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // StartingPlayer
            // 
            this.StartingPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartingPlayer.FormattingEnabled = true;
            this.StartingPlayer.Items.AddRange(new object[] {
            "white",
            "black"});
            this.StartingPlayer.Location = new System.Drawing.Point(71, 214);
            this.StartingPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartingPlayer.Name = "StartingPlayer";
            this.StartingPlayer.Size = new System.Drawing.Size(92, 21);
            this.StartingPlayer.TabIndex = 10;
            this.StartingPlayer.Tag = "";
            this.StartingPlayer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Player";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "starts the game";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "by Piotr Pasich";
            // 
            // ChessTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 280);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartingPlayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.TimeAddedAfterEveryRoundInput);
            this.Controls.Add(this.Player1TimeInput);
            this.Controls.Add(this.Player2TimeInput);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ChessTimer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Chess Timer by Piotr Pasich";
            this.Load += new System.EventHandler(this.ChessTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player2TimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1TimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeAddedAfterEveryRoundInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Player2TimeInput;
        private System.Windows.Forms.NumericUpDown Player1TimeInput;
        private System.Windows.Forms.NumericUpDown TimeAddedAfterEveryRoundInput;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox StartingPlayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

