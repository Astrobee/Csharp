using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Diagnostics;

namespace Wordy
{
    public partial class Form2 : Form
    {
  
        ScoreBoard sBoard;
        Sounds player = new Sounds();

        string[] names = new string[5000];
        double[] ReScores = new double[5000];
        double highestScore = 0.00;
        
        Points calc = new Points();
        string[] wordload;
        StreamReader words;
        
        int lines;
        string Levels = "";
        string player_name;
        
        int timing = 0;
        int lifetime = 0;

        string bravo = "CONGRATSS";
        int bra = 0;
        int swi = 0;

        public Form2(string level, string playerName)
        {
            InitializeComponent();
            player_name = playerName;
            
            life.Text = lifetime.ToString();
            #region Loading words
            try {
                lines = File.ReadAllLines("WordsDatabase.txt").Count();
                words = new StreamReader(File.OpenRead("WordsDatabase.txt"));
                wordload = new string[lines];
                Levels = level;
            }catch(Exception) {}

            try
            {
                for (int j = 0; j < lines; j++)
                {
                    wordload[j] = words.ReadLine().ToLower();
                }
            }catch(Exception) { }
            #endregion

            CountDown();
            countLabel.Text = countdown.ToString();

            Results_Get();  //CALLING RESULTS SORT AND GET METHODS
            Results_Sorting();
            
            highScore.Text = highestScore.ToString();
        }//END OF FORM2 CONSTRUCTOR

        //WORKING WITH WORD SHUFFLING
        int wordcount = 0;
        int countcompare = 0;
        int countdown = 0;

       
        //GENERATING A NEW WORD
        private void nextword_Click(object sender, EventArgs e)
        {
            btnNextWord.Text = "Next Word";
            k = 0;
            wordcount++;
            countdown--;
            countLabel.Text = countdown.ToString();
            timer1.Start();

            //dealing with master controllers
            wordy.Enabled = true;
            txtInput_word.Enabled = true;
            btnCheck.Enabled = true;
            txtInput_word.Select();
            int count = 0;
            
            Random counter = new Random();//Random generator of words
            count = counter.Next(0, lines);

            #region  Code for Level Difficulty
            //checking difficulty      
            
            if (Levels=="Beginner")
            {
                countcompare = 6;
                
            while (wordload[count].Length < 12)//difficulty level: Beginner
            {
                
                count = counter.Next(0, lines);
                
            }
            wordy.Text = wordload[count];
            
            }
            else if(Levels=="Moderate")
            {
                countcompare = 9;
                
                while (wordload[count].Length <9 || wordload[count].Length >11)//difficulty level: Moderate
                {
                    count = counter.Next(0, lines);
                    
                }
                wordy.Text = wordload[count];
                
            }
            else if(Levels=="Expert")
            {
                countcompare = 12;
                
                while (wordload[count].Length > 8 || wordload[count].Length<4)//difficulty level: Expert
                {
                    count = counter.Next(0, lines);
                }
                wordy.Text = wordload[count].ToLower();
                
            }
                #endregion
            //emptying usedwords array after next word
            Array.Clear(usedWords, 0, usedWords.Length);

            if (wordcount == countcompare)
            {
                btnNextWord.Enabled = false;
            }

            here.Visible = false;
            hereLabel.Visible = false;

        }//word shuffling ends here


        //OPENING SCOREBOARD
        private void score_Click(object sender, EventArgs e)
        {
            if(sBoard==null)
            {
                sBoard = new ScoreBoard(player_name, calc.scorePos, countRestart,Levels);
                sBoard.FormClosed += SBoard_FormClosed;
            }

            refresh = ScoreBoard.H_Score_R();
            if(refresh == "1")
            {
             if(countRestart == 0 && refresh == "1")
                {
                    sBoard.label5.Visible = false;
                    sBoard.LabelLast.Visible = false;
                    sBoard.rankLabel.Visible = false;
                }
            }
            
            sBoard.Show(this);
            Hide();
            btnRestartGame.Visible = true;
            
        }

        string reset_cl;
        string refresh;
        //SCOREBOARD FORM CLOSED
        private void SBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            sBoard = null;
            reset_cl = ScoreBoard.ClearCount();
            if (reset_cl == "1")
            {
                score_Click(null, new EventArgs());
                sBoard.label5.Visible = false;
                sBoard.LabelLast.Visible = false;
                sBoard.rankLabel.Visible = false;
            }
            else
                Show();
        }

        string[] usedWords = new string[100];
        int k = -1;
        bool used = false;

       
        bool deduct1 = false;
        bool deduct2 = true;
        bool incre = false;
        int ic = 0;

        
        double thousand = 0;
        string prevCorrect = "";
        //CHECKING FOR WORD
        private void check_Click(object sender, EventArgs e)
        {
            ic = 0;
            bool charAvailable = true;

            foreach (char c in txtInput_word.Text)
            {
                if (!wordy.Text.Contains(c))
                {
                    charAvailable = false;
                    deduct1 = true;
                } 
            }

            if (charAvailable)
            {
                if (usedWords.Contains(txtInput_word.Text))
                {
                    used = true;  
                }
                else
                {
                    used = false; 
                }

                if (wordload.Contains(txtInput_word.Text))
                {
                    deduct2 = false;
                    usedWords[k] = txtInput_word.Text;

                    #region TYPED WORD
                    if (used)
                    {   
                        typedWord.Text= "Word already typed...Try Again";
                        typedWord.Visible = true;
                        inputStatus.Image = Properties.Resources.warnani;
                        player.typedSound();
                        txtInput_word.SelectAll();              
                    }
                    #endregion
                    #region CORRECT WORD
                    else if (!used)
                    {
                        inputStatus.Image = Properties.Resources.correctani;
                        player.correctSound();
                            incre = true;
                        prevCorrect = txtInput_word.Text;
                            
                        //adding marks for correct word
                        foreach (char item in txtInput_word.Text)
                        {
                           for(int ch=0; ch<calc.characters.Length; ch++)
                            {
                                if(item==calc.characters[ch])
                                {
                                    calc.scorePos += + calc.values[ch];
                                    thousand += calc.values[ch];

                                    //checking for life increment
                                        if(thousand >= 1000)
                                        {
                                            lifetime += 1;
                                            thousand -= 1000;
                                        }
                                    life.Text = lifetime.ToString();
                                }
                            }
                            txtInput_word.Clear();
                        }
                        points.Text = calc.scorePos.ToString();
                        thousandLabel.Text = thousand.ToString();

                        //DISPLAYING CONGRATS
                        Congrats();
                        k++;
                    }
                }
                #endregion
                #region WRONG WORD
                else
                {
                inputStatus.Image = Properties.Resources.wrongani;
                    player.wrongSound();
                    txtInput_word.SelectAll();
                    deduct2 = true;
                    incre = false;
                    
                    //deducting marks for wrong word
                    foreach (char item in txtInput_word.Text)
                    {
                        for (int ch = 0; ch < calc.characters.Length; ch++)
                        {
                            if (item == calc.characters[ch])
                            {
                                calc.scorePos -= calc.values[ch];
                            }
                        }
                    }
                    points.Text = calc.scorePos.ToString();
                }
            }

            else if (!charAvailable) {
               inputStatus.Image = Properties.Resources.wrongani;
                player.wrongSound();
                txtInput_word.SelectAll();

                //deducting marks for wrong word
                foreach (char item in txtInput_word.Text)
                {
                    for (int ch = 0; ch < calc.characters.Length; ch++)
                    {
                        if (item == calc.characters[ch])
                        {
                            calc.scorePos -= calc.values[ch];
                        }
                    }
                }
                points.Text = calc.scorePos.ToString();
            }
            #endregion
            btnCheck.Enabled = false;
            txtInput_word.Select();
            inputStatus.Show();
            BuyItems();//enabling or disabling items

        }//END OF CHECK CLICK

        //working with the timer
        int stime = 10;

        //CONGRATS METHOD
        private void Congrats()
        {
            if (calc.scorePos > highestScore)
            {
                timer3.Start();
                congrats.Text = "Highest Scored Overtaken";
                congrats.Visible = true;
                conEmo.Visible = true;
            }
            else
            {
                congrats.Visible = false;
                conEmo.Visible = false;
                timer3.Stop();
                CongratsLabel.Visible = false;
                CongratsLabel.Text = string.Empty;
                bra = 0;
                swi = 0;
            }
        }
        //TIMER FOR TIMING GAME
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Timer
            if (timing == 0)
                timing = 4 * 60 + 5;
            timing--;

            //checking check button availability
            ic++;
            if (ic == 2)
            {
                btnCheck.Enabled = true;
                inputStatus.Visible = false;
                typedWord.Visible = false;
            }

            //penalizing for wrong word
            if (deduct1 == true || deduct2 == true)
            {
                timing -= txtInput_word.Text.Length;
            
                if (timing <= 0)
                    timing = 0;
            }

             if (incre==true)
            {
                timing += prevCorrect.Length;
            }

            timer.Text = timing.ToString();
            if (timing <= 15)
            {
                timer.ForeColor = Color.Red;
                alarmPicture.Image = Properties.Resources.shakealarm;

                    try
                    {
                        player.alarmPlay();
                    }
                    catch (NullReferenceException) { }
            }

            if (timing <= 0)
            {
                //CONTROLS
                btnNextWord.Enabled = false;
                timer1.Stop();
                timer.ForeColor = Color.Red;
                emoji.Image = Properties.Resources.over;
                wordy.Enabled = false;
                txtInput_word.Enabled = false;
                btnCheck.Enabled = false;
                player.alarmStop();
                gameOver_Groupbox.Visible = true;
                timing = 0;
                BuyDisabled();
                #endregion
                
                //SAVE ME
                if (life.Text != 0.ToString())
                {
                    timer2.Start();
                   
                    btnSaveMe.Visible = true;
                    saveEmoji.Visible = true;
                    lifeSec.Visible = true;
                    btnScoreBoard.Visible = false;
                }

                if (life.Text == 0.ToString() && timing == 0)
                {
                    try
                    {
                        using (StreamWriter results = File.AppendText("Results.txt"))
                        {
                            if(calc.scorePos >= 0)
                            results.WriteLine(player_name.ToLower() + "\t" + calc.scorePos);
                        }
                        Results_Get();
                        Results_Sorting();
                    }
                    catch (IOException) { MessageBox.Show("Writing to Results error"); }

                    timer2.Stop();
                    btnScoreBoard.Visible = true;
                    btnSaveMe.Visible = false;
                    saveEmoji.Visible = false;
                    lifeSec.Visible = false;
                }
            }
            else
                BuyItems();

            deduct1 = false;
            deduct2 = false;
            incre = false;

            //loading time emojis
            #region TimeEmojis
            if (timing >= (4 * 60) - 100)
            {
                emoji.Image = Properties.Resources.happy;
                timer.ForeColor = Color.DeepSkyBlue;
            }
            else if (timing >= 40)
            {
                emoji.Image = Properties.Resources.good;
                timer.ForeColor = Color.Yellow;
            }
            else if (timing > 15)
            {
                emoji.Image = Properties.Resources.scared;
                timer.ForeColor = Color.Orange;
            }
            else if (timing > 0)
            {
                emoji.Image = Properties.Resources.angryo;
                timer.ForeColor = Color.Red;
            }
            #endregion

        }//timer ends here

        private void input_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            typedWord.Visible = false;
            inputStatus.Hide();
        }

        //FORM 2
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            words.Dispose();
            player.alarmStop();
            Owner.Show();
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
        }

        //MOUSE HOOVERING OVER
        private void input_MouseEnter(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            typedWord.Visible = false;
            inputStatus.Visible = false;
        }
        int countRestart = 0;
        //RESTARTING GAME
        private void restartGame_Click(object sender, EventArgs e)
        {
            int clines = 0;
            try {
                clines = File.ReadAllLines("Results.txt").Count();
            }
            catch (IOException exx) { MessageBox.Show("reading Results error" + exx.Message); }

            refresh = ScoreBoard.H_Score_R();
            
            if (refresh == "1")
            {
                highestScore = 0;
            }

            refresh = "0";
                for (int j = 0; j < clines; j++)
                {
                    if (highestScore < calc.scorePos)
                        highestScore = calc.scorePos;
                }
            

            
            highScore.Text = highestScore.ToString();
            countRestart += 1;

           #region Restart Set
            btnNextWord.Enabled = true;
            btnNextWord.Text = "Next Word";
            wordy.Text = "wordY";
            gameOver_Groupbox.Visible = false;
            points.Text = 0.ToString();
            calc.scorePos = 0;
            txtInput_word.Text = "";
            countcompare = 0;
            wordcount = 0;
            CountDown();
            countLabel.Text = countdown.ToString();
            Congrats();
            hereLabel.Visible = true;
            here.Visible = true;
            BuyDisabled();
            lifetime = 0;
            thousand = 0;
            thousandLabel.Text = thousand.ToString();

            alarmPicture.Image = Properties.Resources.alarm;
            #endregion 
            inputStatus.Image = null;
            btnRestartGame.Visible = false;            
        }

        //RETRIEVING RESULTS
        public void Results_Get()
        {
            int i = 0;
            try
            {
                using (StreamReader results = new StreamReader(File.OpenRead("Results.txt")))
                {
                    string[] parts = { " " };
                    string lines = " ";

                    while ((lines = results.ReadLine()) != null)
                    {
                        parts = lines.Split('\t');

                        names[i] = parts[0];
                        try {
                            ReScores[i] = Double.Parse(parts[1]);
                        }
                        catch (IOException) { MessageBox.Show("Results Get error"); }
                            i++;
                    }
                }
            }
            catch (IOException) { }
        }

        //POINTS SORTING FOR POSITION
        public void Results_Sorting()
        {
            double temp = 0;
            string name = "";
            int count = 0;

            try {
                count = File.ReadAllLines("Results.txt").Count();
            }
            catch (IOException) { }


            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count; j++)
                {

                    if (ReScores[j] < ReScores[j + 1])
                    {
                        temp = ReScores[j];
                        ReScores[j] = ReScores[j + 1];
                        ReScores[j + 1] = temp;

                        name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;

                    }
                }
            }
            highestScore = ReScores[0];
        }

        //WORDS REMAINING
        public void CountDown()
        {
            try {
                switch (Levels)
                {
                    case "Beginner":
                        countdown = 6;
                        break;

                    case "Moderate":
                        countdown = 9;
                        break;

                    case "Expert":
                        countdown = 12;
                        break;
                }
            }
            catch (Exception) { }
            }
        
        //COLOR SECTION
        private void cd_Click(object sender, EventArgs e)
        {
            ColorDialog cod = new ColorDialog();
            cod.ShowHelp = true;
            cod.HelpRequest += Cod_HelpRequest1;
            if (cod.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = cod.Color;
                wordy.ForeColor = cod.Color;
            }
        }

        //HELP SECTION
        private void Cod_HelpRequest1(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a color for the generated Word");
        }
        string ok = "0";
        private void help2_Click(object sender, EventArgs e)
        {

            ok = MyMessageBox.ShowBox("\"Help\" from here doesn't pause\ngame time.\nChoose Correct icon to continue.", "Take Note");

          if(ok == "1")
            {
                Process h = new Process();
                ProcessStartInfo hs = new ProcessStartInfo();
                hs.FileName = "Notepad.exe";
                hs.Arguments = "Readme.txt";
                h.StartInfo = hs;
                h.Start();
            }
            
        }

        //SAVE ME TIME OUT SECTION
        private void timer2_Tick(object sender, EventArgs e)
        {
            stime--;
            lifeSec.Text = stime.ToString();
            
            if (stime <= 0)
            {
                stime = 0;
                if (lifetime == 0)
                {
                    btnSaveMe.Visible = false;
                    saveEmoji.Visible = false;
                    btnScoreBoard.Visible = true;
                }

                if (life.Text != 0.ToString())
                    stime = 10;

                if (lifetime <= 0)
                    lifetime = 0;

                
                lifetime -= 1;
                life.Text = lifetime.ToString();

                lifeSec.Text = stime.ToString();
            }

            if(life.Text == 0.ToString() && timing == 0)
            {
                try
                {


                    using (StreamWriter results = File.AppendText("Results.txt"))
                    {
                        if (calc.scorePos >= 0)
                            results.WriteLine(player_name.ToLower() + "\t" + calc.scorePos);
                    }

                    Results_Get();
                    Results_Sorting();

                }
                catch (IOException) { MessageBox.Show("Writing to Results error"); }

                timer2.Stop();



                btnScoreBoard.Visible = true;
                btnSaveMe.Visible = false;
                saveEmoji.Visible = false;
                lifeSec.Visible = false;
            }
            
        
        }

        //DISABLING BUYS
        private void BuyDisabled()
        {
            buy15_btn.Enabled = false;
            buy1w_btn.Enabled = false;
            buy25_btn.Enabled = false;
            buy2w_btn.Enabled = false;
            buy60_btn.Enabled = false;
            buy5w_btn.Enabled = false;
        }

        //SAVE ME
        private void saveMe_Click(object sender, EventArgs e)
        {
            try
            {
                lifetime -= 1;
                stime = 10;
                life.Text = lifetime.ToString();


                timer1.Start();
                timer2.Stop();
                timing = 45;

                wordy.Enabled = true;
                txtInput_word.Enabled = true;
                btnCheck.Enabled = true;
                txtInput_word.Select();

                gameOver_Groupbox.Visible = false;
                btnSaveMe.Visible = false;
                saveEmoji.Visible = false;
                lifeSec.Visible = false;

                if (countdown >= 1)
                    btnNextWord.Enabled = true;
                else
                    btnNextWord.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't Save you as Expected");
            }
        }

        //OTHERS
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (btnCheck.Enabled == true)
                {
                    check_Click(null, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                help2_Click(null, new EventArgs());
        }

        //BUYING TIME OR WORDS SECTION
        private void BuyItems()
        {
            Congrats();
            if (calc.scorePos >= 300)
            {
                buy15_btn.Enabled = true;
                buy1w_btn.Enabled = true;
            }
            else
            {
                buy15_btn.Enabled = false;
                buy1w_btn.Enabled = false;
            }

            if (calc.scorePos >= 500)
            {
                buy25_btn.Enabled = true;
                buy2w_btn.Enabled = true;
            }

            else
            {
                buy25_btn.Enabled = false;
                buy2w_btn.Enabled = false;
            }

            if (calc.scorePos >= 1000)
            {
                buy60_btn.Enabled = true;
                buy5w_btn.Enabled = true;
            }
            else
            {
                buy60_btn.Enabled = false;
                buy5w_btn.Enabled = false;
            }
        }
        private void buyword_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button==buy1w_btn)
            {
                countdown += 1;
                countcompare += 1;
                wordcount -= 1;
                calc.scorePos -= 300;
                points.Text = calc.scorePos.ToString();
                countLabel.Text = countdown.ToString();
                BuyItems();
                if (countdown >= 1)
                    btnNextWord.Enabled = true;
            }

            else if(button==buy2w_btn)
            {
                countdown += 2;
                countcompare += 2;
                wordcount -= 2;
                calc.scorePos -= 500;
                points.Text = calc.scorePos.ToString();
                countLabel.Text = countdown.ToString();
                BuyItems();
                if (countdown >= 1)
                    btnNextWord.Enabled = true;
            }

            else if (button == buy5w_btn)
            {
                countdown += 5;
                wordcount -= 5;
                countcompare += 5;
                calc.scorePos -= 1000;
                points.Text = calc.scorePos.ToString();
                countLabel.Text = countdown.ToString();
                BuyItems();
                if (countdown >= 1)
                    btnNextWord.Enabled = true;
            }
        }

        private void buysec_click(object sender, EventArgs e)
        {
            Button button2 = (Button)sender;
            if (button2 == buy15_btn)
            {
                timing += 15;
                timer.Text = timing.ToString();
                calc.scorePos -= 300;
                points.Text = calc.scorePos.ToString();
                BuyItems();

                if (timing >= 0)
                    player.alarmStop();
            }

            else if (button2 == buy25_btn)
            {
                timing += 25;
                timer.Text = timing.ToString();
                calc.scorePos -= 500;
                points.Text = calc.scorePos.ToString();
                BuyItems();

                if (timing >= 0)
                    player.alarmStop();
            }

           else if (button2 == buy60_btn)
            {
                timing += 60;
                timer.Text = timing.ToString();
                calc.scorePos -= 1000;
                points.Text = calc.scorePos.ToString();
                BuyItems();

                if (timing >= 0)
                    player.alarmStop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            CongratsLabel.Visible = true;

            if (swi % 2 == 0)
            {
                timer3.Interval = 65;
                CongratsLabel.ForeColor = Color.LightCyan;
                CongratsLabel.Font = new Font("Elephant", 22);
                congrats.ForeColor = Color.Yellow;
            }
            else
            {
                timer3.Interval = 150;
                CongratsLabel.ForeColor = Color.Yellow;
                CongratsLabel.Font = new Font("Algerian", 26);
                congrats.ForeColor = Color.LightCyan;
            }
            if (bra < bravo.Length)
            {
                CongratsLabel.Text += bravo[bra];
                ++bra;
            }
            if (bra == bravo.Length)
            {
                swi++;
                bra = 0;
                CongratsLabel.Text = String.Empty;
            }
        }
    }//END OF FORM2 CLASS
}
