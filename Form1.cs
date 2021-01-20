using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anons_Yap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            timer1.Enabled = false;
          
            label1timer1saat.Text = DateTime.Now.ToLongTimeString();
            label6timer2saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1timer1saat.Text = DateTime.Now.ToLongTimeString();

            if (label1timer1saat.Text == textBox1.Text)
            {
                axWindowsMediaPlayer1.URL = label3.Text;
            }
        }

        private void button1DosyaSec_Click(object sender, EventArgs e)
        {                               
            OpenFileDialog ekle = new OpenFileDialog();
            ekle.Filter="Mp3 Dosyası|*.mp3";
            ekle.ShowDialog();
            label3.Text = ekle.FileName;
        }

        private void button2kur_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                MessageBox.Show("Dosya Adı Seçmeyi unutmayın..","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                timer1.Enabled = true;
                textBox1.Enabled = false;
                label5aciklama.Text = "Anons Kuruldu";
            }
                      
        }

        private void button3dur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            textBox1.Enabled = true;
            label5aciklama.Text = "Anons Durduruldu..";
            axWindowsMediaPlayer1.close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6timer2saat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
