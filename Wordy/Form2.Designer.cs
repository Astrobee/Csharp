namespace Wordy
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnNextWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wordy = new System.Windows.Forms.Label();
            this.txtInput_word = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alarmPicture = new System.Windows.Forms.PictureBox();
            this.emoji = new System.Windows.Forms.PictureBox();
            this.game_over = new System.Windows.Forms.Label();
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.gameOver_Groupbox = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gameoverpic = new System.Windows.Forms.PictureBox();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.typedWord = new System.Windows.Forms.Label();
            this.inputStatus = new System.Windows.Forms.PictureBox();
            this.nextCount = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.congrats = new System.Windows.Forms.Label();
            this.conEmo = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.here = new System.Windows.Forms.PictureBox();
            this.hereLabel = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveMe = new System.Windows.Forms.Button();
            this.lifeSec = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.help2_btn = new System.Windows.Forms.Button();
            this.buy15_btn = new System.Windows.Forms.Button();
            this.buy25_btn = new System.Windows.Forms.Button();
            this.buy60_btn = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Label();
            this.b25 = new System.Windows.Forms.Label();
            this.b60 = new System.Windows.Forms.Label();
            this.saveEmoji = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buy5w_btn = new System.Windows.Forms.Button();
            this.buy2w_btn = new System.Windows.Forms.Button();
            this.buy1w_btn = new System.Windows.Forms.Button();
            this.aliveLabel = new System.Windows.Forms.Label();
            this.thousandLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.CongratsLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).BeginInit();
            this.gameOver_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameoverpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conEmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.here)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveEmoji)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextWord
            // 
            this.btnNextWord.BackColor = System.Drawing.Color.Transparent;
            this.btnNextWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextWord.Font = new System.Drawing.Font("Broadway", 10F, System.Drawing.FontStyle.Bold);
            this.btnNextWord.ForeColor = System.Drawing.Color.Maroon;
            this.btnNextWord.Location = new System.Drawing.Point(324, 232);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(69, 43);
            this.btnNextWord.TabIndex = 0;
            this.btnNextWord.TabStop = false;
            this.btnNextWord.Text = "New Word";
            this.btnNextWord.UseVisualStyleBackColor = false;
            this.btnNextWord.Click += new System.EventHandler(this.nextword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "WORD:";
            // 
            // wordy
            // 
            this.wordy.AutoSize = true;
            this.wordy.BackColor = System.Drawing.Color.Transparent;
            this.wordy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordy.Enabled = false;
            this.wordy.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordy.ForeColor = System.Drawing.Color.Cyan;
            this.wordy.Location = new System.Drawing.Point(528, 212);
            this.wordy.Name = "wordy";
            this.wordy.Size = new System.Drawing.Size(224, 75);
            this.wordy.TabIndex = 2;
            this.wordy.Text = "wordY";
            // 
            // txtInput_word
            // 
            this.txtInput_word.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtInput_word.Enabled = false;
            this.txtInput_word.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput_word.Location = new System.Drawing.Point(540, 329);
            this.txtInput_word.Name = "txtInput_word";
            this.txtInput_word.Size = new System.Drawing.Size(222, 29);
            this.txtInput_word.TabIndex = 3;
            this.txtInput_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput_word.Click += new System.EventHandler(this.input_Click);
            this.txtInput_word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            this.txtInput_word.MouseEnter += new System.EventHandler(this.input_MouseEnter);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Black;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCheck.Location = new System.Drawing.Point(602, 375);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(93, 33);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.check_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(1128, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score:";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.BackColor = System.Drawing.Color.Transparent;
            this.points.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.points.Location = new System.Drawing.Point(1198, 2);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(27, 27);
            this.points.TabIndex = 6;
            this.points.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BackColor = System.Drawing.Color.Transparent;
            this.timer.Font = new System.Drawing.Font("Baskerville Old Face", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Red;
            this.timer.Location = new System.Drawing.Point(51, 75);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(25, 27);
            this.timer.TabIndex = 8;
            this.timer.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.alarmPicture);
            this.groupBox2.Controls.Add(this.timer);
            this.groupBox2.Controls.Add(this.emoji);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(818, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 105);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timing";
            // 
            // alarmPicture
            // 
            this.alarmPicture.BackColor = System.Drawing.Color.Transparent;
            this.alarmPicture.Image = global::Wordy.Properties.Resources.alarm;
            this.alarmPicture.Location = new System.Drawing.Point(35, 19);
            this.alarmPicture.Name = "alarmPicture";
            this.alarmPicture.Size = new System.Drawing.Size(43, 38);
            this.alarmPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alarmPicture.TabIndex = 12;
            this.alarmPicture.TabStop = false;
            // 
            // emoji
            // 
            this.emoji.Location = new System.Drawing.Point(3, 63);
            this.emoji.Name = "emoji";
            this.emoji.Size = new System.Drawing.Size(42, 39);
            this.emoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji.TabIndex = 13;
            this.emoji.TabStop = false;
            // 
            // game_over
            // 
            this.game_over.AutoSize = true;
            this.game_over.BackColor = System.Drawing.Color.Transparent;
            this.game_over.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_over.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.game_over.Font = new System.Drawing.Font("Borg9", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over.ForeColor = System.Drawing.Color.Red;
            this.game_over.Location = new System.Drawing.Point(1, 16);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(474, 66);
            this.game_over.TabIndex = 2;
            this.game_over.Text = "GAME OVER";
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.BackColor = System.Drawing.Color.Maroon;
            this.btnScoreBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScoreBoard.FlatAppearance.BorderSize = 0;
            this.btnScoreBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoreBoard.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreBoard.ForeColor = System.Drawing.Color.Yellow;
            this.btnScoreBoard.Location = new System.Drawing.Point(189, 112);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(113, 29);
            this.btnScoreBoard.TabIndex = 10;
            this.btnScoreBoard.TabStop = false;
            this.btnScoreBoard.Text = "Score Board";
            this.btnScoreBoard.UseVisualStyleBackColor = false;
            this.btnScoreBoard.Visible = false;
            this.btnScoreBoard.Click += new System.EventHandler(this.score_Click);
            // 
            // gameOver_Groupbox
            // 
            this.gameOver_Groupbox.BackColor = System.Drawing.Color.Transparent;
            this.gameOver_Groupbox.Controls.Add(this.pictureBox2);
            this.gameOver_Groupbox.Controls.Add(this.gameoverpic);
            this.gameOver_Groupbox.Controls.Add(this.btnScoreBoard);
            this.gameOver_Groupbox.Controls.Add(this.game_over);
            this.gameOver_Groupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameOver_Groupbox.Location = new System.Drawing.Point(472, 9);
            this.gameOver_Groupbox.Margin = new System.Windows.Forms.Padding(0);
            this.gameOver_Groupbox.Name = "gameOver_Groupbox";
            this.gameOver_Groupbox.Size = new System.Drawing.Size(488, 143);
            this.gameOver_Groupbox.TabIndex = 17;
            this.gameOver_Groupbox.TabStop = false;
            this.gameOver_Groupbox.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(223, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // gameoverpic
            // 
            this.gameoverpic.BackColor = System.Drawing.Color.Transparent;
            this.gameoverpic.Image = ((System.Drawing.Image)(resources.GetObject("gameoverpic.Image")));
            this.gameoverpic.Location = new System.Drawing.Point(1, 9);
            this.gameoverpic.Name = "gameoverpic";
            this.gameoverpic.Size = new System.Drawing.Size(486, 80);
            this.gameoverpic.TabIndex = 17;
            this.gameoverpic.TabStop = false;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.Aqua;
            this.btnRestartGame.Location = new System.Drawing.Point(670, 168);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(98, 32);
            this.btnRestartGame.TabIndex = 18;
            this.btnRestartGame.TabStop = false;
            this.btnRestartGame.Text = "Play Again";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Visible = false;
            this.btnRestartGame.Click += new System.EventHandler(this.restartGame_Click);
            // 
            // typedWord
            // 
            this.typedWord.AutoSize = true;
            this.typedWord.BackColor = System.Drawing.Color.Aqua;
            this.typedWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.typedWord.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typedWord.ForeColor = System.Drawing.Color.Red;
            this.typedWord.Location = new System.Drawing.Point(537, 421);
            this.typedWord.Name = "typedWord";
            this.typedWord.Size = new System.Drawing.Size(49, 17);
            this.typedWord.TabIndex = 19;
            this.typedWord.Text = "typed";
            this.typedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.typedWord.Visible = false;
            // 
            // inputStatus
            // 
            this.inputStatus.BackColor = System.Drawing.Color.Transparent;
            this.inputStatus.Location = new System.Drawing.Point(770, 332);
            this.inputStatus.Name = "inputStatus";
            this.inputStatus.Size = new System.Drawing.Size(32, 32);
            this.inputStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inputStatus.TabIndex = 11;
            this.inputStatus.TabStop = false;
            // 
            // nextCount
            // 
            this.nextCount.AutoSize = true;
            this.nextCount.BackColor = System.Drawing.Color.Transparent;
            this.nextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nextCount.ForeColor = System.Drawing.Color.Aqua;
            this.nextCount.Location = new System.Drawing.Point(328, 281);
            this.nextCount.Name = "nextCount";
            this.nextCount.Size = new System.Drawing.Size(51, 13);
            this.nextCount.TabIndex = 20;
            this.nextCount.Text = "Remains:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.BackColor = System.Drawing.Color.Transparent;
            this.countLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(375, 278);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(18, 18);
            this.countLabel.TabIndex = 21;
            this.countLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1131, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Highest Score:";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.BackColor = System.Drawing.Color.Transparent;
            this.highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.highScore.ForeColor = System.Drawing.Color.Thistle;
            this.highScore.Location = new System.Drawing.Point(1207, 41);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(16, 17);
            this.highScore.TabIndex = 23;
            this.highScore.Text = "0";
            // 
            // congrats
            // 
            this.congrats.AutoSize = true;
            this.congrats.BackColor = System.Drawing.Color.Transparent;
            this.congrats.Font = new System.Drawing.Font("Harrington", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congrats.ForeColor = System.Drawing.Color.White;
            this.congrats.Location = new System.Drawing.Point(1077, 126);
            this.congrats.Name = "congrats";
            this.congrats.Size = new System.Drawing.Size(174, 15);
            this.congrats.TabIndex = 24;
            this.congrats.Text = "Highest Scored Overtaken";
            this.congrats.Visible = false;
            // 
            // conEmo
            // 
            this.conEmo.BackColor = System.Drawing.Color.Transparent;
            this.conEmo.Image = ((System.Drawing.Image)(resources.GetObject("conEmo.Image")));
            this.conEmo.Location = new System.Drawing.Point(1271, 92);
            this.conEmo.Name = "conEmo";
            this.conEmo.Size = new System.Drawing.Size(49, 45);
            this.conEmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conEmo.TabIndex = 26;
            this.conEmo.TabStop = false;
            this.conEmo.Visible = false;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Aqua;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(457, 232);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(61, 17);
            this.btnColor.TabIndex = 27;
            this.btnColor.TabStop = false;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.cd_Click);
            // 
            // here
            // 
            this.here.BackColor = System.Drawing.Color.Transparent;
            this.here.Image = ((System.Drawing.Image)(resources.GetObject("here.Image")));
            this.here.Location = new System.Drawing.Point(288, 244);
            this.here.Name = "here";
            this.here.Size = new System.Drawing.Size(30, 24);
            this.here.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.here.TabIndex = 29;
            this.here.TabStop = false;
            // 
            // hereLabel
            // 
            this.hereLabel.AutoSize = true;
            this.hereLabel.BackColor = System.Drawing.Color.Transparent;
            this.hereLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hereLabel.ForeColor = System.Drawing.Color.Aqua;
            this.hereLabel.Location = new System.Drawing.Point(252, 249);
            this.hereLabel.Name = "hereLabel";
            this.hereLabel.Size = new System.Drawing.Size(37, 15);
            this.hereLabel.TabIndex = 30;
            this.hereLabel.Text = "Start";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.BackColor = System.Drawing.Color.Transparent;
            this.life.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.life.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.life.Location = new System.Drawing.Point(1046, 5);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(21, 24);
            this.life.TabIndex = 6;
            this.life.Text = "0";
            this.life.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1012, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveMe
            // 
            this.btnSaveMe.BackColor = System.Drawing.Color.Black;
            this.btnSaveMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMe.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMe.ForeColor = System.Drawing.Color.Lime;
            this.btnSaveMe.Location = new System.Drawing.Point(1009, 35);
            this.btnSaveMe.Name = "btnSaveMe";
            this.btnSaveMe.Size = new System.Drawing.Size(66, 33);
            this.btnSaveMe.TabIndex = 32;
            this.btnSaveMe.TabStop = false;
            this.btnSaveMe.Text = "Save Me";
            this.btnSaveMe.UseVisualStyleBackColor = false;
            this.btnSaveMe.Visible = false;
            this.btnSaveMe.Click += new System.EventHandler(this.saveMe_Click);
            // 
            // lifeSec
            // 
            this.lifeSec.AutoSize = true;
            this.lifeSec.BackColor = System.Drawing.Color.Transparent;
            this.lifeSec.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.lifeSec.ForeColor = System.Drawing.Color.Thistle;
            this.lifeSec.Location = new System.Drawing.Point(1035, 71);
            this.lifeSec.Name = "lifeSec";
            this.lifeSec.Size = new System.Drawing.Size(18, 18);
            this.lifeSec.TabIndex = 23;
            this.lifeSec.Text = "0";
            this.lifeSec.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // help2_btn
            // 
            this.help2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.help2_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.help2_btn.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.help2_btn.ForeColor = System.Drawing.Color.Snow;
            this.help2_btn.Location = new System.Drawing.Point(851, 411);
            this.help2_btn.Name = "help2_btn";
            this.help2_btn.Size = new System.Drawing.Size(51, 23);
            this.help2_btn.TabIndex = 28;
            this.help2_btn.TabStop = false;
            this.help2_btn.Text = "Help?";
            this.help2_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.help2_btn.UseVisualStyleBackColor = false;
            this.help2_btn.Click += new System.EventHandler(this.help2_Click);
            // 
            // buy15_btn
            // 
            this.buy15_btn.AutoSize = true;
            this.buy15_btn.BackColor = System.Drawing.Color.Teal;
            this.buy15_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy15_btn.Enabled = false;
            this.buy15_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buy15_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buy15_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buy15_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy15_btn.ForeColor = System.Drawing.Color.Maroon;
            this.buy15_btn.Location = new System.Drawing.Point(1043, 576);
            this.buy15_btn.Name = "buy15_btn";
            this.buy15_btn.Size = new System.Drawing.Size(45, 30);
            this.buy15_btn.TabIndex = 33;
            this.buy15_btn.TabStop = false;
            this.buy15_btn.Text = "15s";
            this.buy15_btn.UseVisualStyleBackColor = false;
            this.buy15_btn.Click += new System.EventHandler(this.buysec_click);
            // 
            // buy25_btn
            // 
            this.buy25_btn.AutoSize = true;
            this.buy25_btn.BackColor = System.Drawing.Color.Teal;
            this.buy25_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy25_btn.Enabled = false;
            this.buy25_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buy25_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buy25_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buy25_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy25_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buy25_btn.Location = new System.Drawing.Point(1102, 576);
            this.buy25_btn.Name = "buy25_btn";
            this.buy25_btn.Size = new System.Drawing.Size(45, 30);
            this.buy25_btn.TabIndex = 33;
            this.buy25_btn.TabStop = false;
            this.buy25_btn.Text = "25s";
            this.buy25_btn.UseVisualStyleBackColor = false;
            this.buy25_btn.Click += new System.EventHandler(this.buysec_click);
            // 
            // buy60_btn
            // 
            this.buy60_btn.AutoSize = true;
            this.buy60_btn.BackColor = System.Drawing.Color.Teal;
            this.buy60_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy60_btn.Enabled = false;
            this.buy60_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buy60_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buy60_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buy60_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy60_btn.ForeColor = System.Drawing.Color.Yellow;
            this.buy60_btn.Location = new System.Drawing.Point(1161, 576);
            this.buy60_btn.Name = "buy60_btn";
            this.buy60_btn.Size = new System.Drawing.Size(45, 30);
            this.buy60_btn.TabIndex = 33;
            this.buy60_btn.TabStop = false;
            this.buy60_btn.Text = "60s";
            this.buy60_btn.UseVisualStyleBackColor = false;
            this.buy60_btn.Click += new System.EventHandler(this.buysec_click);
            // 
            // b15
            // 
            this.b15.AutoSize = true;
            this.b15.BackColor = System.Drawing.Color.Transparent;
            this.b15.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.b15.Location = new System.Drawing.Point(1052, 560);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(26, 16);
            this.b15.TabIndex = 34;
            this.b15.Text = "300";
            // 
            // b25
            // 
            this.b25.AutoSize = true;
            this.b25.BackColor = System.Drawing.Color.Transparent;
            this.b25.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.b25.Location = new System.Drawing.Point(1111, 560);
            this.b25.Name = "b25";
            this.b25.Size = new System.Drawing.Size(26, 16);
            this.b25.TabIndex = 34;
            this.b25.Text = "500";
            // 
            // b60
            // 
            this.b60.AutoSize = true;
            this.b60.BackColor = System.Drawing.Color.Transparent;
            this.b60.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.b60.Location = new System.Drawing.Point(1168, 560);
            this.b60.Name = "b60";
            this.b60.Size = new System.Drawing.Size(32, 16);
            this.b60.TabIndex = 34;
            this.b60.Text = "1000";
            // 
            // saveEmoji
            // 
            this.saveEmoji.BackColor = System.Drawing.Color.Transparent;
            this.saveEmoji.Image = ((System.Drawing.Image)(resources.GetObject("saveEmoji.Image")));
            this.saveEmoji.Location = new System.Drawing.Point(977, 35);
            this.saveEmoji.Name = "saveEmoji";
            this.saveEmoji.Size = new System.Drawing.Size(31, 32);
            this.saveEmoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.saveEmoji.TabIndex = 35;
            this.saveEmoji.TabStop = false;
            this.saveEmoji.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("French Script MT", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(1071, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 31);
            this.label4.TabIndex = 36;
            this.label4.Text = "Buy Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("French Script MT", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(224, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 31);
            this.label5.TabIndex = 43;
            this.label5.Text = "Buy Word";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label6.Location = new System.Drawing.Point(324, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label7.Location = new System.Drawing.Point(267, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label8.Location = new System.Drawing.Point(208, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "300";
            // 
            // buy5w_btn
            // 
            this.buy5w_btn.AutoSize = true;
            this.buy5w_btn.BackColor = System.Drawing.Color.Teal;
            this.buy5w_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy5w_btn.Enabled = false;
            this.buy5w_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buy5w_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buy5w_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buy5w_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy5w_btn.ForeColor = System.Drawing.Color.Yellow;
            this.buy5w_btn.Location = new System.Drawing.Point(317, 571);
            this.buy5w_btn.Name = "buy5w_btn";
            this.buy5w_btn.Size = new System.Drawing.Size(45, 30);
            this.buy5w_btn.TabIndex = 37;
            this.buy5w_btn.TabStop = false;
            this.buy5w_btn.Text = "5w";
            this.buy5w_btn.UseVisualStyleBackColor = false;
            this.buy5w_btn.Click += new System.EventHandler(this.buyword_click);
            // 
            // buy2w_btn
            // 
            this.buy2w_btn.AutoSize = true;
            this.buy2w_btn.BackColor = System.Drawing.Color.Teal;
            this.buy2w_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy2w_btn.Enabled = false;
            this.buy2w_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buy2w_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buy2w_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buy2w_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy2w_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buy2w_btn.Location = new System.Drawing.Point(258, 571);
            this.buy2w_btn.Name = "buy2w_btn";
            this.buy2w_btn.Size = new System.Drawing.Size(45, 30);
            this.buy2w_btn.TabIndex = 38;
            this.buy2w_btn.TabStop = false;
            this.buy2w_btn.Text = "2w";
            this.buy2w_btn.UseVisualStyleBackColor = false;
            this.buy2w_btn.Click += new System.EventHandler(this.buyword_click);
            // 
            // buy1w_btn
            // 
            this.buy1w_btn.AutoSize = true;
            this.buy1w_btn.BackColor = System.Drawing.Color.Teal;
            this.buy1w_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy1w_btn.Enabled = false;
            this.buy1w_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buy1w_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buy1w_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buy1w_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy1w_btn.ForeColor = System.Drawing.Color.Maroon;
            this.buy1w_btn.Location = new System.Drawing.Point(199, 571);
            this.buy1w_btn.Name = "buy1w_btn";
            this.buy1w_btn.Size = new System.Drawing.Size(45, 30);
            this.buy1w_btn.TabIndex = 39;
            this.buy1w_btn.TabStop = false;
            this.buy1w_btn.Text = "1w";
            this.buy1w_btn.UseVisualStyleBackColor = false;
            this.buy1w_btn.Click += new System.EventHandler(this.buyword_click);
            // 
            // aliveLabel
            // 
            this.aliveLabel.AutoSize = true;
            this.aliveLabel.BackColor = System.Drawing.Color.Transparent;
            this.aliveLabel.ForeColor = System.Drawing.Color.White;
            this.aliveLabel.Location = new System.Drawing.Point(1131, 28);
            this.aliveLabel.Name = "aliveLabel";
            this.aliveLabel.Size = new System.Drawing.Size(58, 13);
            this.aliveLabel.TabIndex = 22;
            this.aliveLabel.Text = "Life Score:";
            // 
            // thousandLabel
            // 
            this.thousandLabel.AutoSize = true;
            this.thousandLabel.BackColor = System.Drawing.Color.Transparent;
            this.thousandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.thousandLabel.ForeColor = System.Drawing.Color.Thistle;
            this.thousandLabel.Location = new System.Drawing.Point(1186, 26);
            this.thousandLabel.Name = "thousandLabel";
            this.thousandLabel.Size = new System.Drawing.Size(16, 17);
            this.thousandLabel.TabIndex = 23;
            this.thousandLabel.Text = "0";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // CongratsLabel
            // 
            this.CongratsLabel.AutoSize = true;
            this.CongratsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CongratsLabel.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongratsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.CongratsLabel.Location = new System.Drawing.Point(1073, 92);
            this.CongratsLabel.Name = "CongratsLabel";
            this.CongratsLabel.Size = new System.Drawing.Size(26, 39);
            this.CongratsLabel.TabIndex = 44;
            this.CongratsLabel.Text = ".";
            this.CongratsLabel.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wordy.Properties.Resources.wordybac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 712);
            this.Controls.Add(this.CongratsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buy5w_btn);
            this.Controls.Add(this.buy2w_btn);
            this.Controls.Add(this.buy1w_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveEmoji);
            this.Controls.Add(this.b60);
            this.Controls.Add(this.b25);
            this.Controls.Add(this.b15);
            this.Controls.Add(this.buy60_btn);
            this.Controls.Add(this.buy25_btn);
            this.Controls.Add(this.buy15_btn);
            this.Controls.Add(this.btnSaveMe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hereLabel);
            this.Controls.Add(this.here);
            this.Controls.Add(this.help2_btn);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.conEmo);
            this.Controls.Add(this.congrats);
            this.Controls.Add(this.lifeSec);
            this.Controls.Add(this.thousandLabel);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.aliveLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.nextCount);
            this.Controls.Add(this.typedWord);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.gameOver_Groupbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inputStatus);
            this.Controls.Add(this.life);
            this.Controls.Add(this.points);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtInput_word);
            this.Controls.Add(this.wordy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextWord);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wordY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).EndInit();
            this.gameOver_Groupbox.ResumeLayout(false);
            this.gameOver_Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameoverpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conEmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.here)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveEmoji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wordy;
        private System.Windows.Forms.TextBox txtInput_word;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox inputStatus;
        private System.Windows.Forms.PictureBox alarmPicture;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.PictureBox emoji;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label game_over;
        public System.Windows.Forms.Button btnScoreBoard;
        private System.Windows.Forms.GroupBox gameOver_Groupbox;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label typedWord;
        private System.Windows.Forms.Label nextCount;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.Label congrats;
        private System.Windows.Forms.PictureBox gameoverpic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox conEmo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox here;
        private System.Windows.Forms.Label hereLabel;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaveMe;
        private System.Windows.Forms.Label lifeSec;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button help2_btn;
        private System.Windows.Forms.Button buy15_btn;
        private System.Windows.Forms.Button buy25_btn;
        private System.Windows.Forms.Button buy60_btn;
        private System.Windows.Forms.Label b15;
        private System.Windows.Forms.Label b25;
        private System.Windows.Forms.Label b60;
        private System.Windows.Forms.PictureBox saveEmoji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buy5w_btn;
        private System.Windows.Forms.Button buy2w_btn;
        private System.Windows.Forms.Button buy1w_btn;
        private System.Windows.Forms.Label aliveLabel;
        private System.Windows.Forms.Label thousandLabel;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label CongratsLabel;
    }
}