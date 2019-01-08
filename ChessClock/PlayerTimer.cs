using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessClock
{
    class PlayerTimer
    {
        private const int interval = 10;
        private TimeSpan countDown;
        private Timer timer;
        private int timeToAddAfterEveryMove;

        public PlayerTimer(int timeInMinutes, int timeToAddAfterEveryMove = 0)
        {
            this.timeToAddAfterEveryMove = timeToAddAfterEveryMove;
            countDown = TimeSpan.FromMinutes(timeInMinutes);
            timer = new Timer();
            timer.Interval = interval;
            timer.Tick += new EventHandler(this.Tick);
        }

        public bool isValid()
        {
            return (countDown.TotalSeconds > 0);
        }

        public string GetTimeString()
        {
            if (!isValid()) {
                return "00:00:00";
            }
            return countDown.ToString(@"hh\:mm\:ss");
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Switch()
        {
            if (timer.Enabled) {
                timer.Stop();
            } else {
                countDown = countDown.Add(TimeSpan.FromSeconds(timeToAddAfterEveryMove));
                timer.Start();
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            countDown = countDown.Subtract(TimeSpan.FromMilliseconds(interval));
        }
    }
}
