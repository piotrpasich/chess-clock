using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessClock
{
    public partial class GameController : Form
    {
        private Color backgroundColor = Color.IndianRed;
        private PlayerTimer player1Time;
        private PlayerTimer player2Time;
        private Form previousPage;

        private Timer timer;

        public GameController(
            Form PreviousPage, 
            int player1Time, 
            int player2Time, 
            int timeAddedAfterEveryMove = 0,
            int startingPlayer = 0 // 0 for white, 1 for black
            )
        {
            InitializeComponent();
            WinnerLabel.Visible = false;
            SwitchPlayerButton.Visible = true;
            StartStopButton.Visible = true;

            this.previousPage = PreviousPage;

            this.player1Time = new PlayerTimer(player1Time, timeAddedAfterEveryMove);
            this.player2Time = new PlayerTimer(player2Time, timeAddedAfterEveryMove);

            Player1TimeLabel.Text = this.player1Time.GetTimeString();
            Player2TimeLabel.Text = this.player2Time.GetTimeString();

            StartPlayer(startingPlayer);

            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(this.Tick);
            timer.Start();
        }

        private void StartPlayer(int player)
        {
            if (player == 0) {
                SwitchColor(WhiteLabel);
                player1Time.Start();
            } else {
                SwitchColor(BlackLabel);
                player2Time.Start();
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            Player1TimeLabel.Text = player1Time.GetTimeString();
            Player2TimeLabel.Text = player2Time.GetTimeString();

            if (!player1Time.isValid() || !player2Time.isValid()) {
                string winner = player1Time.isValid() ? "White" : "Black";
                WinnerLabel.Text = string.Format("Congratulations! {0} won the game!", winner);
                WinnerLabel.Visible = true;
                SwitchPlayerButton.Visible = false;
                StartStopButton.Visible = false;
                player1Time.Stop();
                player2Time.Stop();
            }
        }

        private void Player2TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Player1TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void SwitchPlayerButton_Click(object sender, EventArgs e)
        {
            player1Time.Switch();
            player2Time.Switch();
            SwitchColor(WhiteLabel);
            SwitchColor(BlackLabel);
        }

        private void SwitchColor(Label label)
        {
            if (backgroundColor == label.BackColor) {
                label.BackColor = Color.Transparent;
            } else {
                label.BackColor = backgroundColor;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StartStopButton.Text == "Stop") {
                SwitchPlayerButton.Enabled = false;
                StartStopButton.Text = "Start";
                player1Time.Stop();
                player2Time.Stop();
            } else {
                SwitchPlayerButton.Enabled = true;
                StartStopButton.Text = "Stop";

                if (WhiteLabel.BackColor == backgroundColor) {
                    player1Time.Start();
                } else {
                    player2Time.Start();
                }
            }
        }

        private void GameController_Load(object sender, EventArgs e)
        {

        }

        private void WinnerLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // switch between forms
            previousPage.Show();
            Hide();
        }
    }
}
