using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy
{
    public class WordShuffle
    {
        //working with word shuffling
        private void nextword_Click(object sender, EventArgs e)
        {

            timer1.Start();

            //dealing with master controllers
            wordy.Enabled = true;
            input.Enabled = true;
            check.Enabled = true;

            StreamReader words = new StreamReader(File.OpenRead("finalwords.txt"));
            String[] wordload = new String[235885];
            for (int j = 0; j < 235885; j++)
            {
                wordload[j] = words.ReadLine();
            }
            Random counter = new Random();
            int count = counter.Next(0, 235885);
            while (wordload[count].Length < 4 || wordload[count].Length > 8)//difficulty level: Difficult
            {
                count = counter.Next(0, 235885);
            }
            wordy.Text = wordload[count];
            // nextword.Enabled = false;

        }//word shuffling ends here
    }
}
