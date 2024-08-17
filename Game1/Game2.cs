using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Game2 : Form
    {

        int sp = 5;
        int diem = 10;
        int x1, x2, y1, y2;

        SoundPlayer Amdiem = new SoundPlayer("nhay.wav");
        SoundPlayer AmThua = new SoundPlayer("ThuaGame.wav");
        SoundPlayer Ambay = new SoundPlayer("amBay.wav");
        Random rd = new Random();

        int sptenLua = 13;
        public Game2()
        {
            InitializeComponent();
            Resest();
        }

        private void Game2_Load(object sender, EventArgs e)
        {

        }
        private int GameOver()
        {
            if (bird.Bounds.IntersectsWith(pipe1.Bounds) ||
                bird.Bounds.IntersectsWith(pipe2.Bounds) ||
                bird.Bounds.IntersectsWith(tenLua.Bounds) ||
                bird.Top <= this.ClientRectangle.Top ||
                bird.Bottom >= this.ClientRectangle.Bottom)
            {
                return 1;
            }
            return 0;
        }
        private void Resest()
        {

            diem = 10;
            x1 = this.Width;
            y1 = 89;

            x2 = pipe1.Width + 1100;
            y2 = 231;

            timer1.Interval = 1;
            timer1.Start();
        }

        private void nutPlay_Click(object sender, EventArgs e)
        {
            this.Close();
            new Game2().Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            x1 -= 5;
            x2 -= 5;

            bird.Top += sp;

            pipe1.Location = new Point(x1, y1);
            pipe2.Location = new Point(x2, y2);

            if (x1 + pipe1.Width <= 80)
            {

                // hiện lại đằng sau cặp ống cống 2
                x1 = pipe2.Width + 800;               
                y1 = rd.Next(20, 270);
                pipe1.Location = new Point(x1, y1);

                Amdiem.Play();
                diem++;

            }

            if (x2 + pipe2.Width <= 80)
            {

                x2 = pipe2.Width + 800;
                y2 = rd.Next(20, 270);
                pipe2.Location = new Point(x2, y2);

                Amdiem.Play();
                diem++;
            }


            lbDiem.Text = diem.ToString();
            if (diem > 10)
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
                            x.Left = this.ClientSize.Width + 300;
                            x.Top = y;
                        }


                    }
                }
            }
            if (GameOver()==1)
            {
                timer1.Stop();
                AmThua.Play();
                bird.Location = new Point(59, 450);
                grEnd.Visible = true;
                lbDiem.Visible = false;
                Play.Visible = false;
                Dung.Visible = false;


                lbInDiem.Text = diem.ToString();

            }

            if (diem > 5 && diem < 20)
            {
                x1 -= 2;
                x2 -= 2;
            }
            else if (diem > 21)
            {
                x1 -= 4;
                x2 -= 4;
            }


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                sp = -6;

            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOver() != 1 && e.KeyCode == Keys.Space)
            {
                sp = 5;
                Ambay.Play();
            }
        }

    }
}
