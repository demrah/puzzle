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
    
    public partial class Oyun : Form
    {

        Image myImage;       // Ekranda görünecek olan resim
        int seviye;          // oyun seviyesi
        PictureBox[,] dizim; //oyun seviyesine göre şekillencek olan PictureBox dizisi
        PictureBox Aktif;    //Aktif olan PictureBox
        Random rnd;          //Random Nesne
        int[] xTemp ;        //Resim parçalarının random X koordinatlarını tutan dizi
        int[] yTemp;         //Resim parçalarının random Y koordinatlarını tutan dizi
        bool capraz;
        Point[,] eskiHal;    //Resim parçalarının X ve Y koordinatlarının normal değerlerini tutan Point dizisi
        
        public Oyun()
        {
            InitializeComponent();
        }
        private void Oyun_Load(object sender, EventArgs e)
        {
            myImage = Puzzle.frmPuzzle.MyImage;// oyun sınıfının global myImage nesnesine frmPuzzle daki image nesnesini atadık
            seviye = Puzzle.frmPuzzle.Seviye;//oyun sınıfının global seviye nesnesine frmPuzzle daki seviye nesnesini atadık
            rnd = new Random();
            capraz = Puzzle.frmPuzzle.Capraz;
            olustur(seviye+2);      //  olustur adlı fonksiyonu çağırıyoruz...
        }

      
        private void olustur(int seviye) 
        {
            dizim = new PictureBox[seviye, seviye];

            Randomize(seviye);                      // xtemp ve yTemp değerlerine random değerler atanması için.
            eskiHal = new Point[seviye, seviye];    // 
            for (int i = 0; i < seviye; i++)
            {
                for (int j = 0; j < seviye; j++)
                {
                    dizim[i, j] = new PictureBox();

                    dizim[i, j].Click += new EventHandler(Degistir);
                    Point p = new Point(xTemp[i] * (300 / seviye), yTemp[j] * (300 / seviye));
                    
                    dizim[i, j].Location = p;
                    eskiHal[i, j] = dizim[i, j].Location;

                    Rectangle recTemp = new Rectangle(dizim[i, j].Location, new Size((300 / seviye), (300 / seviye)));
                    Bitmap bitmap = new Bitmap(myImage);
                    Bitmap cropped = bitmap.Clone(recTemp, System.Drawing.Imaging.PixelFormat.Undefined);

                    dizim[i, j].BorderStyle = BorderStyle.FixedSingle;
                    dizim[i, j].Image = cropped;

                    dizim[i, j].Width = (300 / seviye);
                    dizim[i, j].Height = (300 / seviye);
                    this.Controls.Add(dizim[i, j]);

                }
            }


            for (int i = 0; i < seviye; i++)
            {
                for (int j = 0; j < seviye; j++)
                {
                    dizim[i, j].Top = i * (300 / seviye);
                    dizim[i, j].Left = j * (300 / seviye);
                    dizim[i, j].Width = (300 / seviye);
                    dizim[i, j].Height = (300 / seviye);
                }
            }


            
            Aktif = dizim[seviye-1, seviye-1];
            
            Aktif.Dispose();
            
        
        }
        
        void Degistir(object sender, EventArgs e)
        {
            PictureBox pGelen =(PictureBox)sender;
            Point ptemp= Aktif.Location;
            
            if (capraz)
                {
                    if (pGelen.Location.X + pGelen.Width == ptemp.X && pGelen.Location.Y + pGelen.Height == ptemp.Y)
                    {

                        Aktif.Location = pGelen.Location;

                        pGelen.Location = ptemp;
                    }
                    if (pGelen.Location.X - pGelen.Width == ptemp.X && pGelen.Location.Y - pGelen.Height == ptemp.Y)
                    {

                        Aktif.Location = pGelen.Location;

                        pGelen.Location = ptemp;
                    }
                    if (pGelen.Location.X - pGelen.Width == ptemp.X && pGelen.Location.Y + pGelen.Height == ptemp.Y)
                    {

                        Aktif.Location = pGelen.Location;

                        pGelen.Location = ptemp;
                    }
                    if (pGelen.Location.X + pGelen.Width == ptemp.X && pGelen.Location.Y - pGelen.Height == ptemp.Y)
                    {

                        Aktif.Location = pGelen.Location;

                        pGelen.Location = ptemp;
                    }
                }



                

                if (pGelen.Location.X==ptemp.X)
                {
                    if (Math.Abs(pGelen.Location.Y - ptemp.Y) == 300 / Math.Sqrt(dizim.Length) )
                    {
                        Aktif.Location = pGelen.Location;

                        pGelen.Location = ptemp;
                    }
                }
                else if (pGelen.Location.Y == ptemp.Y)
                {
                    if (Math.Abs(pGelen.Location.X - ptemp.X) == 300 / Math.Sqrt(dizim.Length) )
                    {

                        Aktif.Location = pGelen.Location;

                        pGelen.Location = ptemp;

                    }
                }

        }



        private void Randomize(int a)
        {
            
            xTemp=new int[a];
            yTemp=new int[a];
            int durum=1;
            Random rnd=new Random();

            for (int i = 0; i < a; i++)
            {

                while (durum==1)
                {
                    int Temp;
                    Temp = rnd.Next(0, a);
                    durum = Bakk(Temp,i,xTemp);
                    if (durum==0)
                    {
                        xTemp[i] = Temp;
                    }

                }
                durum = 1;
            }
            durum = 1;
            for (int i = 0; i < a; i++)
            {
                
                while (durum==1)
                {
                    int Temp = rnd.Next(0, a);

                    durum = Bakk(Temp, i, yTemp);
                    if (durum == 0)
                    {
                        yTemp[i] = Temp;
                    }
                }
                durum = 1;
            }
        
        }
        private int Bakk(int a,int i,int []dizi) 
        {
            for (int k = 0; k < i; k++)
            {
                 if (a == dizi[k])  

                 {  

                     return 1;  

                 }  
            }
            return 0;
        }

        private void Bitir(int a)
        {

            double b = Math.Sqrt(a);
            
            bool Btemp=true;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (eskiHal[i,j]!=dizim[i,j].Location)
                    {
                        Btemp = false;
                    }
                }
            }

            if (Btemp)
            {

                YouWin winner = new YouWin();
                winner.ShowDialog();
            }
            else 
            {
                YouAreWrong wrong = new YouAreWrong();
                wrong.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitir(dizim.Length);
        }

    }
}
