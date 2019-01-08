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
    public partial class Congratulations : Form
    {

        public Congratulations(string winner)
        {
            InitializeComponent();
            WinnerLabel.Text = string.Format("Congratulations! {0} won the game!", winner);
        }

        private void Congratulations_Load(object sender, EventArgs e)
        {
            
        }
    }
}
