using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessClock {
    public partial class ChessTimer : Form {
        const int DEFAULT_TIME = 60;

        public ChessTimer() {
            InitializeComponent();
        }

        private void ChessTimer_Load(object sender, EventArgs e) {
            StartingPlayer.SelectedIndex = 0;
            Player1TimeInput.Value = DEFAULT_TIME;
            Player2TimeInput.Value = DEFAULT_TIME;
        }

        private void button1_Click(object sender, EventArgs e) {
            // switch between forms
            Hide();
            GameController gameController = new GameController(
                this,
                (int) Player1TimeInput.Value,
                (int) Player2TimeInput.Value,
                (int) TimeAddedAfterEveryRoundInput.Value,
                StartingPlayer.SelectedIndex
                );
            gameController.Closed += (s, args) => this.Close();
            gameController.StartPosition = this.StartPosition;
            gameController.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
