using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class StartGame : Form
    {

        int ktraAmThanh = 1;
        playSound ps = new playSound();
        public StartGame()
        {
            InitializeComponent();
            Amthanh_Click(null, null);


        }

        private void PLAYGAME1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CAVEGAME2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game2().Show();
        }

        private void Amthanh_Click(object sender, EventArgs e)
        {
            if (ktraAmThanh == 1)
            {
                ps.OpenMediaFile("mmm.mp3");
                ps.PlayMediaFile(true);
                Amthanh.Text = "Tắt Âm Thanh";
                ktraAmThanh = 0;
            }
            else
            {
                ps.ClosePlayer();
                Amthanh.Text = "Bật Âm Thanh";
                ktraAmThanh = 1;
            }
        }
    }
}
