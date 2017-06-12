namespace Wordy
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.loading = new System.Windows.Forms.ProgressBar();
            this.timing = new System.Windows.Forms.Timer(this.components);
            this.astroboy = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.CopyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.SystemColors.Control;
            this.loading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loading.Location = new System.Drawing.Point(0, 413);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(288, 13);
            this.loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loading.TabIndex = 0;
            // 
            // timing
            // 
            this.timing.Interval = 1000;
            this.timing.Tick += new System.EventHandler(this.timing_Tick);
            // 
            // astroboy
            // 
            this.astroboy.AutoSize = true;
            this.astroboy.BackColor = System.Drawing.Color.Transparent;
            this.astroboy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.astroboy.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.astroboy.ForeColor = System.Drawing.Color.Silver;
            this.astroboy.Location = new System.Drawing.Point(219, 398);
            this.astroboy.Name = "astroboy";
            this.astroboy.Size = new System.Drawing.Size(0, 15);
            this.astroboy.TabIndex = 1;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.ForeColor = System.Drawing.Color.White;
            this.CopyrightLabel.Location = new System.Drawing.Point(16, 397);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(134, 13);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "2016 AstroSoft Corporation";
            // 
            // CopyLabel
            // 
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyLabel.ForeColor = System.Drawing.Color.White;
            this.CopyLabel.Location = new System.Drawing.Point(-2, 394);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(21, 19);
            this.CopyLabel.TabIndex = 2;
            this.CopyLabel.Text = "©";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(288, 426);
            this.Controls.Add(this.CopyLabel);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.astroboy);
            this.Controls.Add(this.loading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wordY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loading;
        private System.Windows.Forms.Timer timing;
        private System.Windows.Forms.Label astroboy;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Label CopyLabel;
    }
}