using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace Game1
{
    public partial class Form1 : Form
    {

        SoundPlayer AmDiem = new SoundPlayer("nhay.wav");
        SoundPlayer AmThua = new SoundPlayer("ThuaGame.wav");
        SoundPlayer Ambay = new SoundPlayer("amBay.wav");

        int sp = 5;
        int diem = 0;
        int DoChenhLech= 130;
        int x_cap1, x_cap2;
        int y_ongtren1;
        int y_ongduoi1;
        int y_ongtren2;
        int y_ongduoi2;
        int sptenLua = 15;

        public Form1()
        {
            InitializeComponent();
            this.SetDoubleBuffered();
            Resest();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private int GameOver()
        {

            if (bird.Bounds.IntersectsWith(pipeT1.Bounds) ||
               bird.Bounds.IntersectsWith(pipeT2.Bounds) ||
               bird.Bounds.IntersectsWith(pipeD2.Bounds) ||
               bird.Bounds.IntersectsWith(pipeD1.Bounds) ||
               bird.Bounds.IntersectsWith(Tenlua2.Bounds) ||
               bird.Top <= this.ClientRectangle.Top ||
               bird.Bottom >= this.ClientRectangle.Bottom)
            {
                return 1;
            }
            return 0;
        }
        private void Resest()
        {


            diem = 0;
            x_cap1 = this.Width; // vi tri ban dau ong 1;
            y_ongtren1 = -640; 

            y_ongduoi1 = 800 + y_ongtren1 + DoChenhLech;

            x_cap2 = pipeT1.Width + 1100; //khoan cach giua ong 1 va 2
            
            y_ongtren2 = -530; 

            y_ongduoi2 = 800 + y_ongtren2 + DoChenhLech;


            timer1.Interval = 1;
            timer1.Start();
        }


     
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            x_cap1 -= 4;
            x_cap2 -= 4;
            
            bird.Top += sp;

            pipeT1.Location = new Point(x_cap1, y_ongtren1);
            pipeD1.Location = new Point(x_cap1, y_ongduoi1);
            pipeT2.Location = new Point(x_cap2, y_ongtren2);
            pipeD2.Location = new Point(x_cap2, y_ongduoi2);

            if (x_cap1 + pipeT1.Width <= 80)
            {
                x_cap1 = pipeT2.Width + 800; 
                Random rd = new Random();
                y_ongtren1 = rd.Next(-700, -450);
              
                y_ongduoi1 = (800 + y_ongtren1) + DoChenhLech;
                pipeT1.Location = new Point(x_cap1, y_ongtren1);
                pipeD1.Location = new Point(x_cap1, y_ongduoi1);

                AmDiem.Play();
                diem++;
            }


            if (x_cap2 + pipeT2.Width <= 80)
            {
                x_cap2 = pipeD1.Width + 800; 
                Random rd = new Random();
                y_ongtren2 = rd.Next(-700, -450);
                y_ongduoi2 = (800 + y_ongtren2) + DoChenhLech;

                pipeT2.Location = new Point(x_cap2, y_ongtren2);
                pipeD2.Location = new Point(x_cap2, y_ongduoi2);

                AmDiem.Play();
                diem++;
            }

            lbDiem.Text = diem.ToString();

            
            if (diem>10) // tạo vật cản khí điểm > 10
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "TenLua")  
                    {
                        x.Left -= sptenLua;
                        if (x.Left < -100)
                        {
                            Random rd = new Random();
                            int y = rd.Next(this.ClientSize.Height - x.Height);
                            x.Left = this.ClientSize.Width+300;
                            x.Top = y;
                        }


                    }
                }
            }
            

            if (GameOver()==1)
            {
                Ambay.Stop();
                AmThua.Play();

                Play.Visible = false;
                Dung.Visible = false;
                lbDiem.Visible = false;
                timer1.Stop();
                bird.Location = new Point(59, 450);
                grEnd.Visible = true;
                lbinDiem.Text = diem.ToString();

            }



            if (diem > 5 && diem < 20)
            {
                x_cap1 -= 2;
                x_cap2 -= 2;
            }
            else if (diem > 21)
            {
                x_cap1 -= 4;
                x_cap2 -= 4;
            }            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                sp = -5;

            }
        }

        private void nutPlay_Click(object sender, EventArgs e)
        {

            this.Close();
            new Form1().Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            StartGame formB = new StartGame();
            formB.Show(); 
        }

        private void Dung_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Dung.Visible = false;
            Play.Visible = true;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Play.Visible = false;
            Dung.Visible = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (GameOver() != 1 && e.KeyCode == Keys.Space)
            {
                sp = 4;
                Ambay.Play();
            }
        }
        
    }
}
