namespace Wordy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAbout = new System.Windows.Forms.Button();
            this.DifficultycomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.musicBox = new System.Windows.Forms.PictureBox();
            this.txtplayerName = new System.Windows.Forms.TextBox();
            this.btnGamer = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.MytoolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.musicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbout.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Blue;
            this.btnAbout.Location = new System.Drawing.Point(90, 406);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(58, 21);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MytoolTip.SetToolTip(this.btnAbout, "About this Game");
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // DifficultycomboBox
            // 
            this.DifficultycomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DifficultycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultycomboBox.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultycomboBox.ForeColor = System.Drawing.Color.Red;
            this.DifficultycomboBox.FormattingEnabled = true;
            this.DifficultycomboBox.Items.AddRange(new object[] {
            "Beginner",
            "Moderate",
            "Expert"});
            this.DifficultycomboBox.Location = new System.Drawing.Point(112, 7);
            this.DifficultycomboBox.Name = "DifficultycomboBox";
            this.DifficultycomboBox.Size = new System.Drawing.Size(121, 28);
            this.DifficultycomboBox.TabIndex = 2;
            this.DifficultycomboBox.TabStop = false;
            this.MytoolTip.SetToolTip(this.DifficultycomboBox, "Choose Level of Game Difficulty");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "DIFFICULTY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "PLAYER:";
            // 
            // musicBox
            // 
            this.musicBox.BackColor = System.Drawing.Color.Transparent;
            this.musicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicBox.Image = global::Wordy.Properties.Resources.musicresized;
            this.musicBox.Location = new System.Drawing.Point(-1, 386);
            this.musicBox.Name = "musicBox";
            this.musicBox.Size = new System.Drawing.Size(45, 41);
            this.musicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.musicBox.TabIndex = 6;
            this.musicBox.TabStop = false;
            this.MytoolTip.SetToolTip(this.musicBox, "Double-Click to Stop Music\r\nSingle-Click to Restart Music");
            this.musicBox.Click += new System.EventHandler(this.musicBox_Click);
            this.musicBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.musicBox_MouseDoubleClick);
            this.musicBox.MouseLeave += new System.EventHandler(this.musicBox_MouseLeave);
            this.musicBox.MouseHover += new System.EventHandler(this.musicBox_MouseHover);
            // 
            // txtplayerName
            // 
            this.txtplayerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtplayerName.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplayerName.ForeColor = System.Drawing.Color.Maroon;
            this.txtplayerName.Location = new System.Drawing.Point(112, 40);
            this.txtplayerName.MaxLength = 15;
            this.txtplayerName.Name = "txtplayerName";
            this.txtplayerName.Size = new System.Drawing.Size(121, 26);
            this.txtplayerName.TabIndex = 8;
            this.txtplayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtplayerName.TextChanged += new System.EventHandler(this.txtplayerName_TextChanged);
            this.txtplayerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtplayerName_KeyDown);
            this.txtplayerName.Validating += new System.ComponentModel.CancelEventHandler(this.playerName_Validating);
            // 
            // btnGamer
            // 
            this.btnGamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGamer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGamer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGamer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGamer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGamer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGamer.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamer.ForeColor = System.Drawing.Color.Cyan;
            this.btnGamer.Location = new System.Drawing.Point(101, 128);
            this.btnGamer.Name = "btnGamer";
            this.btnGamer.Size = new System.Drawing.Size(96, 40);
            this.btnGamer.TabIndex = 9;
            this.btnGamer.Text = "Start Game";
            this.btnGamer.UseVisualStyleBackColor = false;
            this.btnGamer.Click += new System.EventHandler(this.btnGamer_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelp.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnHelp.ForeColor = System.Drawing.Color.Snow;
            this.btnHelp.Location = new System.Drawing.Point(43, 406);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(51, 23);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help?";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MytoolTip.SetToolTip(this.btnHelp, "View Readme File");
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.help_Click);
            // 
            // notify
            // 
            this.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "wordY";
            this.notify.Visible = true;
            this.notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseClick);
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(231, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 21);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Quit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MytoolTip.SetToolTip(this.btnExit, "Close this Game");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Wordy.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(288, 426);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGamer);
            this.Controls.Add(this.txtplayerName);
            this.Controls.Add(this.musicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DifficultycomboBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wordY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.musicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox DifficultycomboBox;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox musicBox;
        public System.Windows.Forms.TextBox txtplayerName;
        private System.Windows.Forms.Button btnGamer;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip MytoolTip;
    }
}

