using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DWYMplayer
{
    public partial class Form1 : Form
    {
        int Top;
        int MoveX;
        int MoveY;
        string[] files, paths;
        public Form1()
        {
            InitializeComponent();
            panelleft.Visible = false;
           
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Channel10Btn_Click(object sender, EventArgs e)
        {
            panelleft.Visible = true;
            panelleft.Height = Channel10Btn.Height;
            panelleft.Top = Channel10Btn.Top;
        }

        private void Channel12Btn_Click(object sender, EventArgs e)
        {
            panelleft.Visible = true;
            panelleft.Height = Channel12Btn.Height;
            panelleft.Top = Channel12Btn.Top;
        }

        private void Channel13Btn_Click(object sender, EventArgs e)
        {
            panelleft.Visible = true;
            panelleft.Height = Channel13Btn.Height;
            panelleft.Top = Channel13Btn.Top;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            

            if(DwymPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if(playList.SelectedIndex == 0)
                {
                    playList.SelectedIndex = 0;
                    playList.Update();
                }
                else
                {
                    DwymPlayer.Ctlcontrols.previous();
                    playList.SelectedIndex -= 1;
                    playList.Update();
                }
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            
            
     
                playList.SelectedIndex = 0;
                DwymPlayer.Ctlcontrols.play();
            
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if(DwymPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                DwymPlayer.Ctlcontrols.play();
            }
            else
            {
                DwymPlayer.Ctlcontrols.pause();
            }
            
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            DwymPlayer.Ctlcontrols.stop();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            
            if(DwymPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if(playList.SelectedIndex < (playList.Items.Count - 1))
                {
                    DwymPlayer.Ctlcontrols.next();
                    playList.SelectedIndex +=1;
                    playList.Update();
                }
                else
                {
                    playList.SelectedIndex = 0;
                    playList.Update();
                }
            }
        }

        private void OpenPlayList_Click(object sender, EventArgs e)
        {
            BrowseBtn.PerformClick();
        }

        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DwymPlayer.URL = paths[playList.SelectedIndex];
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DwymPlayer.uiMode = "none";
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int rate = 100 * (trackBar1.Value -10 );
            DwymPlayer.settings.volume = trackBar1.Value ;
        }

        private void MuteBtn_Click(object sender, EventArgs e)
        {
            if(DwymPlayer.settings.volume == 100)
            {
                DwymPlayer.settings.volume = 0;
               
            }
            else
            {
                DwymPlayer.settings.volume = 100;
            }
        }

        private void FullScreenBtn_Click(object sender, EventArgs e)
        {
            if(DwymPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                DwymPlayer.fullScreen = true;

            }
            else
            {
                DwymPlayer.fullScreen = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Top = 1;
            MoveX = e.X;
            MoveY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Top == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MoveX -1, MousePosition.Y - MoveY -1);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Top = 0;
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            string userName = System.Environment.UserName;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\" + userName + "\\Documents\\MyMusic";
            ofd.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg;*.mkv;|all files|*.*";
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                
                for(int i = 0; i<files.Length; i++)
                {
                    playList.Items.Add(files[i]);
                    
                }
            }
        }
    }
}
