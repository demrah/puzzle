using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class frmPuzzle : Form
    {
        private static Image myImage;
        private static int seviye;
        private static bool capraz;

        public static bool Capraz
            {get { return frmPuzzle.capraz; }}
        public static Image MyImage
        {
        get { return frmPuzzle.myImage; }
        }
        public static int Seviye
        {
            get { return frmPuzzle.seviye; }
        }
        
        public frmPuzzle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdResimAc.Title = "Lütfen Resim Dosyası Seçiniz";
            ofdResimAc.Filter = " (*.jpg)|*.jpg|(*.png)|*.png";
            ofdResimAc.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            myImage = Image.FromFile(ofdResimAc.FileName);

            pChosed.Image = myImage;//Global olan myImage nesnemize seçtiğimiz resmi atadık.
       
            btnStartGame.Enabled = true;//Başlama butonunu aktif Hale getirdik.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seviye.Equals(0))
            {
                MessageBox.Show("Seviyeyi seçiniz", "Seviye", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (myImage==null)
            {
                MessageBox.Show("Resim seçiniz","Resim",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            Oyun myGame = new Oyun();//yeni bir Oyun nesnesi oluşturuluyor...
            myGame.ShowDialog();//myGame nesnesi gösteriliyor...
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSeviye.SelectedIndex==0)
            {
                seviye = 1;
            }
            else if (cbSeviye.SelectedIndex == 1)
            {
                seviye = 2;
            }
            else if (cbSeviye.SelectedIndex == 2)
            {
                seviye = 3;
            }
            else if (cbSeviye.SelectedIndex == 3)
            {
                seviye = 4;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            capraz = checkBox1.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            myImage = null;
            pChosed.Image = null;
        }


    }
}
