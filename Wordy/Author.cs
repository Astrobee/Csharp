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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            facebookLink.Text = "Facebook Page";
            facebookLink.Links.Add(0, 0, "www.Facebook.com/osei.clement");

            instagramLink.Text = "Instagram Page";
            instagramLink.Links.Add(0, 0, "www.instagram.com/astro_frimps");
        }
        private void facebookLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void instagramLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameInfo_Click(object sender, EventArgs e)
        {
            Resources.AboutBox1 abt = new Resources.AboutBox1();
                abt.Show();
        }
    }
}
