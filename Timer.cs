using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Timer : Form
    {
        int time = 0;
        public Timer()
        {
            InitializeComponent();

            Random RND = new Random();
            time = RND.Next(3, 15) * 60;
            timer1.Start();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minutes = time / 60;
            int seconds = time % 60;
            if (time >= 0)
            {
                lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
                time--;
            }
            else
                timer1.Stop();
        }
    }
}
