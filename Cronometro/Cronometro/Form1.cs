using System;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        int h = 0;
        int m = 0;
        int s = 0;
        Timer timer;
        bool timeIsRunning = false;
        int pushStop = 0;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            s += 1;

            if (s > 59)
            {
                s = 0;
                m += 1;
            }

            if (m > 59)
            {
                m = 0;
                h += 1;
            }

            ss.Text = s.ToString("00");
            ms.Text = m.ToString("00");
            hs.Text = h.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeIsRunning = true;
            pushStop = 0;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeIsRunning = false;
            pushStop++;
            timer.Stop();
            if (timeIsRunning == false && pushStop == 2)
            {
                pushStop = 0;
                s = 0;
                m = 0;
                h = 0;
                ss.Text = "00";
                ms.Text = "00";
                hs.Text = "00";
            }
        }
    }
}
