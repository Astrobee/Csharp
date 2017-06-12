using System;
using System.Windows.Forms;

namespace Wordy
{
    
    public partial class Splash : Form
    {
        string author = "AstroBoy";
        int pos = 0;
        public Splash()
        {
            InitializeComponent();
            timing.Start();   
        }

        private void startDelay()
        {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();  
        }

        private void timing_Tick(object sender, EventArgs e)
        {
            timing.Interval = 500;
            loading.PerformStep();
           if(loading.Value==100)
            {
                timing.Stop();
                startDelay();
            }

           if(pos < author.Length)
            {
                astroboy.ForeColor = System.Drawing.Color.Yellow;
                astroboy.Text += author[pos];
                ++pos;
            }
        }
    }
}
