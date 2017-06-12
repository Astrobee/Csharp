using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Wordy
{
    public partial class Form1 : Form
    {


        Sounds player = new Sounds();
        Results load = new Results();
        Form2 f2;
        public Form1()
        {

            try
            {
                StreamReader create;
                if (!File.Exists("Results.txt"))
                    create = new StreamReader(File.Create("Results.txt"));
            }
            catch (IOException) { MessageBox.Show("Creating Results error"); }

          //  GrantAccess("Results.txt");

            
            InitializeComponent();
            int diff = 0;

            Random rand = new Random();
            diff = rand.Next(0, 2);
            DifficultycomboBox.SelectedIndex = diff;
            DifficultycomboBox.Select();

            load.Results_Get();
            player.BackMusic();
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
            Show();
        }
 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void musicBox_Click(object sender, EventArgs e)
        {
            player.BackMusic();
            musicBox.Image = Properties.Resources.musicresized;

        }

        private void musicBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            player.BackMusicStop();
            musicBox.Image = Properties.Resources.musicStop;
        }

        private void musicBox_MouseHover(object sender, EventArgs e)
        {
            musicBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void musicBox_MouseLeave(object sender, EventArgs e)
        {
            musicBox.BorderStyle = BorderStyle.None;
        }

        private void help_Click(object sender, EventArgs e)
        {
            Process h = new Process();
            ProcessStartInfo hs = new ProcessStartInfo();
            hs.FileName = "Notepad.exe";
            hs.Arguments = "Readme.txt";
            h.StartInfo = hs;
            h.Start();
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notify_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift)
            {
                player.BackMusicStop();
                musicBox.Image = Properties.Resources.musicStop;
            }

            if(e.Control && e.Alt)
            {
                player.BackMusic();
                musicBox.Image = Properties.Resources.musicresized;
            }


            if (e.KeyCode == Keys.F1)
                help_Click(null, new EventArgs());

            if (e.KeyCode == Keys.F2)
                btnAbout_Click(null, new EventArgs());
        }


        private void playerName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtplayerName.Text == "")
            {
                MyErrorProvider.SetError(txtplayerName, "Please Provide a Name");
                e.Cancel = true;
            }

            else if (txtplayerName.Text.Length < 4)
            {
                MyErrorProvider.SetError(txtplayerName, "Name too Short");
                e.Cancel = true;
            }

            else if (txtplayerName.Text.Contains(" "))
            {
                MyErrorProvider.SetError(txtplayerName, "Name must contain no Spaces");
                e.Cancel = true;
            }

            else
            {
                MyErrorProvider.SetError(txtplayerName, "");
                e.Cancel = false;
            }
        }

        private void btnGamer_Click(object sender, EventArgs e)
        {
            if (txtplayerName.Text == string.Empty)
            {
                MyErrorProvider.SetError(txtplayerName, "Please Provide a Name");
                txtplayerName.Select();
            }
            else
            {
                try
                {
                    if (f2 == null)
                    {
                        f2 = new Form2(DifficultycomboBox.Text, txtplayerName.Text);
                        f2.FormClosed += F2_FormClosed;
                    }
                    f2.Show(this);
                    Hide();
                    notify.ShowBalloonTip(1000, "wordY", "wordY Startup window still running\nDouble Click to display", ToolTipIcon.Info);

                    txtplayerName.Text = "";
                }
                catch (Exception) { };
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtplayerName_TextChanged(object sender, EventArgs e)
        {
            if (txtplayerName.Text.Length>=4)
            {
                MyErrorProvider.SetError(txtplayerName, "");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string exit = "";
            exit = MyMessageBox.ShowBox("Do you really want to Close wordY?", "Exiting wordY Game");
            if (exit == "1")
                this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Show();
        }

        private void txtplayerName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnGamer_Click(null, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}


