namespace DWYMplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.playList = new System.Windows.Forms.ListBox();
            this.panelleft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Channel13Btn = new System.Windows.Forms.Button();
            this.Channel12Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Channel10Btn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.PictureBox();
            this.MinBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DwymPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FullScreenBtn = new System.Windows.Forms.Button();
            this.MuteBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.OpenPlayList = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DwymPlayer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.BrowseBtn);
            this.panel1.Controls.Add(this.playList);
            this.panel1.Controls.Add(this.panelleft);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Channel13Btn);
            this.panel1.Controls.Add(this.Channel12Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Channel10Btn);
            this.panel1.Controls.Add(this.MaxBtn);
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 631);
            this.panel1.TabIndex = 0;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.FlatAppearance.BorderSize = 0;
            this.BrowseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BrowseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BrowseBtn.Image = global::DWYMplayer.Properties.Resources.folder_vectors_512;
            this.BrowseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseBtn.Location = new System.Drawing.Point(22, 259);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(187, 40);
            this.BrowseBtn.TabIndex = 11;
            this.BrowseBtn.Text = "  Browse";
            this.BrowseBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BrowseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.playList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playList.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 21;
            this.playList.Location = new System.Drawing.Point(16, 357);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(181, 252);
            this.playList.TabIndex = 10;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelleft.Location = new System.Drawing.Point(3, 128);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(7, 35);
            this.panelleft.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Play List :";
            // 
            // Channel13Btn
            // 
            this.Channel13Btn.FlatAppearance.BorderSize = 0;
            this.Channel13Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Channel13Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Channel13Btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Channel13Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Channel13Btn.Image = global::DWYMplayer.Properties.Resources.tv5;
            this.Channel13Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Channel13Btn.Location = new System.Drawing.Point(22, 213);
            this.Channel13Btn.Name = "Channel13Btn";
            this.Channel13Btn.Size = new System.Drawing.Size(187, 40);
            this.Channel13Btn.TabIndex = 7;
            this.Channel13Btn.Text = "Channel 13";
            this.Channel13Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Channel13Btn.UseVisualStyleBackColor = true;
            this.Channel13Btn.Click += new System.EventHandler(this.Channel13Btn_Click);
            // 
            // Channel12Btn
            // 
            this.Channel12Btn.FlatAppearance.BorderSize = 0;
            this.Channel12Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Channel12Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Channel12Btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Channel12Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Channel12Btn.Image = global::DWYMplayer.Properties.Resources.tv5;
            this.Channel12Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Channel12Btn.Location = new System.Drawing.Point(22, 169);
            this.Channel12Btn.Name = "Channel12Btn";
            this.Channel12Btn.Size = new System.Drawing.Size(187, 40);
            this.Channel12Btn.TabIndex = 6;
            this.Channel12Btn.Text = "Channel 12";
            this.Channel12Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Channel12Btn.UseVisualStyleBackColor = true;
            this.Channel12Btn.Click += new System.EventHandler(this.Channel12Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            // 
            // Channel10Btn
            // 
            this.Channel10Btn.FlatAppearance.BorderSize = 0;
            this.Channel10Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Channel10Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Channel10Btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Channel10Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Channel10Btn.Image = global::DWYMplayer.Properties.Resources.tv5;
            this.Channel10Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Channel10Btn.Location = new System.Drawing.Point(22, 123);
            this.Channel10Btn.Name = "Channel10Btn";
            this.Channel10Btn.Size = new System.Drawing.Size(187, 40);
            this.Channel10Btn.TabIndex = 4;
            this.Channel10Btn.Text = "Channel 10";
            this.Channel10Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Channel10Btn.UseVisualStyleBackColor = true;
            this.Channel10Btn.Click += new System.EventHandler(this.Channel10Btn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackgroundImage = global::DWYMplayer.Properties.Resources._018_maximize;
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaxBtn.Location = new System.Drawing.Point(45, 12);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(30, 30);
            this.MaxBtn.TabIndex = 3;
            this.MaxBtn.TabStop = false;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.Button_Delete;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinBtn.Location = new System.Drawing.Point(9, 12);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(30, 30);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.TabStop = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.Button_Close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.Location = new System.Drawing.Point(81, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panel2.Controls.Add(this.DwymPlayer);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 631);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DwymPlayer
            // 
            this.DwymPlayer.Enabled = true;
            this.DwymPlayer.Location = new System.Drawing.Point(-2, 144);
            this.DwymPlayer.Name = "DwymPlayer";
            this.DwymPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("DwymPlayer.OcxState")));
            this.DwymPlayer.Size = new System.Drawing.Size(791, 399);
            this.DwymPlayer.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel3.Controls.Add(this.FullScreenBtn);
            this.panel3.Controls.Add(this.MuteBtn);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.OpenPlayList);
            this.panel3.Controls.Add(this.NextBtn);
            this.panel3.Controls.Add(this.StopBtn);
            this.panel3.Controls.Add(this.PauseBtn);
            this.panel3.Controls.Add(this.PlayBtn);
            this.panel3.Controls.Add(this.BackBtn);
            this.panel3.Location = new System.Drawing.Point(0, 533);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 98);
            this.panel3.TabIndex = 2;
            // 
            // FullScreenBtn
            // 
            this.FullScreenBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.full_screen;
            this.FullScreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FullScreenBtn.FlatAppearance.BorderSize = 0;
            this.FullScreenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FullScreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreenBtn.Location = new System.Drawing.Point(688, 38);
            this.FullScreenBtn.Name = "FullScreenBtn";
            this.FullScreenBtn.Size = new System.Drawing.Size(49, 42);
            this.FullScreenBtn.TabIndex = 102;
            this.FullScreenBtn.UseVisualStyleBackColor = true;
            this.FullScreenBtn.Click += new System.EventHandler(this.FullScreenBtn_Click);
            // 
            // MuteBtn
            // 
            this.MuteBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.Volume;
            this.MuteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MuteBtn.FlatAppearance.BorderSize = 0;
            this.MuteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteBtn.Location = new System.Drawing.Point(485, 38);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(49, 42);
            this.MuteBtn.TabIndex = 8;
            this.MuteBtn.UseVisualStyleBackColor = true;
            this.MuteBtn.Click += new System.EventHandler(this.MuteBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(528, 53);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(144, 45);
            this.trackBar1.TabIndex = 101;
            this.trackBar1.TickFrequency = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 70;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // OpenPlayList
            // 
            this.OpenPlayList.BackgroundImage = global::DWYMplayer.Properties.Resources.Button_Add;
            this.OpenPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenPlayList.FlatAppearance.BorderSize = 0;
            this.OpenPlayList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OpenPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPlayList.Location = new System.Drawing.Point(408, 38);
            this.OpenPlayList.Name = "OpenPlayList";
            this.OpenPlayList.Size = new System.Drawing.Size(49, 42);
            this.OpenPlayList.TabIndex = 6;
            this.OpenPlayList.UseVisualStyleBackColor = true;
            this.OpenPlayList.Click += new System.EventHandler(this.OpenPlayList_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.Button_Last;
            this.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Location = new System.Drawing.Point(353, 38);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(49, 42);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.Button_Stop;
            this.StopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopBtn.FlatAppearance.BorderSize = 0;
            this.StopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Location = new System.Drawing.Point(298, 38);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(49, 42);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.Button_Pause;
            this.PauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PauseBtn.FlatAppearance.BorderSize = 0;
            this.PauseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBtn.Location = new System.Drawing.Point(243, 38);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(49, 42);
            this.PauseBtn.TabIndex = 3;
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.Button_Play;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Location = new System.Drawing.Point(188, 38);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(49, 42);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::DWYMplayer.Properties.Resources.Button_First;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Location = new System.Drawing.Point(133, 38);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(49, 42);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DWYMplayer.Properties.Resources.logo3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DWYM Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DwymPlayer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MaxBtn;
        private System.Windows.Forms.PictureBox MinBtn;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Channel10Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Channel13Btn;
        private System.Windows.Forms.Button Channel12Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button OpenPlayList;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.ListBox playList;
        private AxWMPLib.AxWindowsMediaPlayer DwymPlayer;
        private System.Windows.Forms.Button MuteBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button FullScreenBtn;
    }
}

