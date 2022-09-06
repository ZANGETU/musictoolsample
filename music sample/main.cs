using System;
using System.Windows.Forms;
using System.Media;

namespace music_sample
{
    public partial class main : Form
    {
        public main(){
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e){
        }
        private void button1_Click(object sender, EventArgs e){
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "音楽ファイルを選んでね";
            ofd.InitialDirectory = @"C:/Desktop/";
            ofd.FileName = "";
            ofd.Filter = "オーディオファイル | *.mp3; *.wav;";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true; 
            /*
            * ofd.Multiselect = true;
            */
            ofd.ReadOnlyChecked = true;
            ofd.Dispose();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = (ofd.FileName);
            }
        }
        private void button2_Click(object sender, EventArgs e){
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = (textBox1.Text);
        }
        private void button3_Click(object sender, EventArgs e){
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
