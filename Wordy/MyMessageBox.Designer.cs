namespace Wordy
{
    partial class MyMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBox));
            this.OKbutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.boxTime = new System.Windows.Forms.Label();
            this.mtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.AutoSize = true;
            this.OKbutton.BackColor = System.Drawing.SystemColors.Control;
            this.OKbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OKbutton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.OKbutton.Image = ((System.Drawing.Image)(resources.GetObject("OKbutton.Image")));
            this.OKbutton.Location = new System.Drawing.Point(207, 112);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(4);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(39, 32);
            this.OKbutton.TabIndex = 0;
            this.OKbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.Location = new System.Drawing.Point(247, 112);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(39, 32);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.message.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Black;
            this.message.Location = new System.Drawing.Point(2, 50);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(62, 17);
            this.message.TabIndex = 1;
            this.message.Text = "message";
            // 
            // boxTime
            // 
            this.boxTime.AutoSize = true;
            this.boxTime.BackColor = System.Drawing.Color.Transparent;
            this.boxTime.ForeColor = System.Drawing.Color.White;
            this.boxTime.Location = new System.Drawing.Point(3, 123);
            this.boxTime.Name = "boxTime";
            this.boxTime.Size = new System.Drawing.Size(15, 18);
            this.boxTime.TabIndex = 2;
            this.boxTime.Text = "5";
            // 
            // mtimer
            // 
            this.mtimer.Interval = 1000;
            this.mtimer.Tick += new System.EventHandler(this.mtimer_Tick);
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.boxTime);
            this.Controls.Add(this.message);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKbutton);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMessageBox";
            this.Load += new System.EventHandler(this.MyMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbutton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label boxTime;
        private System.Windows.Forms.Timer mtimer;
    }
}