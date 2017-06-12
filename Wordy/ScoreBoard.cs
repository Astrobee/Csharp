using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Wordy
{
    public partial class ScoreBoard : Form
    {

        
        
        Results load = new Results();
        Sounds player = new Sounds();
        List<Label> playerLabels = new List<Label>();

        string pname;
        double scorepos;
        int rangePosition = 0;
        int outRangePosition = 0;
        int countRestart = 0;

        static string reset_scores = "0";
        static string refresh_high = "0";
        string gameLevel = "";

        
        //int clearCount = 0;
        public ScoreBoard(string pname, double score, int countRestart, string level)
        {
            InitializeComponent();
            this.pname = pname;
            scorepos = score;
            gameLevel = level;

            this.countRestart = countRestart;

            load.Results_Get();
            load.Results_Sorting();

            Display_Results();
        }
        



        private void ScoreBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ccc == 0)
                button_clicked = "0";
            else
            {
                button_clicked = "1";
                refresh_high = "1";
            }
            reset_scores = button_clicked;
            ClearCount();
            H_Score_R();
            //Owner.Show();
        }

       

       public void Display_Results()
        {
            
            int yaxis = 20;
            int o= 0;
            int e= 1;
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                playerLabels.Add(new Label());
                playerLabels.Add(new Label());

                if (load.names[i] == null)//checking for empty player names
                    load.names[i] = "Empty";
                  
                //loading players and scores
                playerLabels[o].Text = load.names[i];
                playerLabels[e].Text = load.ReScores[i].ToString();

                playerLabels[e].ForeColor = Color.Cyan;

                if (playerLabels[o].Text == "Empty")//formatting empty player names
                {
                    playerLabels[o].Font = new Font("Times New Roman", 13);
                    playerLabels[o].ForeColor = Color.DarkGray;
                    playerLabels[e].ForeColor = Color.DarkGray;
                }

                playerLabels[e].Font = new Font("Lucida Fax", 13);

                if (playerLabels[e].Text == scorepos.ToString() && playerLabels[o].Text == this.pname)//checking for current player score
                {
                    playerLabels[e].ForeColor = Color.Yellow;
                    playerLabels[e].BackColor = Color.Black;
                }

                //label controls
                playerLabels[e].Parent = scoreBox;
                playerLabels[o].Parent = scoreBox;
                playerLabels[o].Location = new Point(30, yaxis);
                playerLabels[e].Location = new Point(165, yaxis);
                playerLabels[o].BringToFront();
                playerLabels[e].BringToFront();

                if (i <10)
                {
                    if (playerLabels[o].Text == this.pname && playerLabels[e].Text == scorepos.ToString())//checking for current player name
                    {
                        rangePosition = i + 1;
                        playerLabels[o].ForeColor = Color.Yellow;
                        playerLabels[o].BackColor = Color.Black;
                        PositionText.Text = rangePosition.ToString();
                        PositionText.Show();

                    }
                   
                }



                else  if( i >=10)
                {
                    
                    if (playerLabels[o].Text == this.pname && playerLabels[e].Text == scorepos.ToString())
                    {
                        outRangePosition = i + 1;
                        PositionText.Text = outRangePosition.ToString();
                        PositionText.Show();

                        LabelLast.ForeColor = Color.Red;
                        LabelLast.Show();
                    }

                }

                sboardLevel.Text = gameLevel;

                o += 2;
                e += 2;
                yaxis += 25;
            } 
           
        }

        string button_clicked;
        int ccc = 0;
        private void clear_Click(object sender, System.EventArgs e)
        {
            button_clicked = MyMessageBox.ShowBox("Do you want to clear game progress?","Clear Game Records");
            ccc = 0;
            if (button_clicked == "1")
            {
                string paths = "Results.txt";
                try
                {
                    File.WriteAllText(paths, string.Empty);
                }
                catch (System.Exception)
                { }

                finally
                {
                    reset_scores = button_clicked;
                    ClearCount();

                    refresh_high = button_clicked;
                    H_Score_R();
                    ccc = 1;
                    this.Close();
                }
            }
            else
            {
                ccc = 0;
            }
        }

        public static string ClearCount()
        {
            return reset_scores;
        }

        public static string H_Score_R()
        {
            return refresh_high;
        }
    }
}
