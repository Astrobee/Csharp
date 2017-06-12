using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordy
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        static MyMessageBox newMessageBox;
        static string Button_id;
        int disposeTime = 0;

        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.message.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.message.Text = txtMessage;
            newMessageBox.Text = txtTitle;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newMessageBox.Dispose();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            newMessageBox.Dispose();
            Button_id = "2";
        }

        private void mtimer_Tick(object sender, EventArgs e)
        {
            disposeTime--;
            if (disposeTime >= 0)
            {
                newMessageBox.boxTime.Text = disposeTime.ToString();
            }

            else
            {
                newMessageBox.Dispose();
            }
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            disposeTime = 6;
            mtimer.Start();
        }
    }
}
