using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Media File |*.mp3";
            file.InitialDirectory = Application.StartupPath;
            file.Title = "Dosya seç";
            file.ShowDialog();
            textBox1.Text = file.FileName;
            axWindowsMediaPlayer1.URL = textBox1.Text;

        }
    }
}
