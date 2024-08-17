using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Game1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDiem = new System.Windows.Forms.Label();
            this.grEnd = new System.Windows.Forms.GroupBox();
            this.lbinDiem = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.nutPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Dung = new System.Windows.Forms.PictureBox();
            this.pipeD2 = new System.Windows.Forms.PictureBox();
            this.pipeT2 = new System.Windows.Forms.PictureBox();
            this.pipeT1 = new System.Windows.Forms.PictureBox();
            this.pipeD1 = new System.Windows.Forms.PictureBox();
            this.Tenlua2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tenlua2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Stencil Std", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.IndianRed;
            this.lbDiem.Location = new System.Drawing.Point(52, 9);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(48, 53);
            this.lbDiem.TabIndex = 5;
            this.lbDiem.Text = "0";
            // 
            // grEnd
            // 
            this.grEnd.BackColor = System.Drawing.Color.Silver;
            this.grEnd.Controls.Add(this.lbinDiem);
            this.grEnd.Controls.Add(this.Menu);
            this.grEnd.Controls.Add(this.nutPlay);
            this.grEnd.Controls.Add(this.label2);
            this.grEnd.Controls.Add(this.label1);
            this.grEnd.Location = new System.Drawing.Point(285, 49);
            this.grEnd.Name = "grEnd";
            this.grEnd.Size = new System.Drawing.Size(427, 467);
            this.grEnd.TabIndex = 7;
            this.grEnd.TabStop = false;
            this.grEnd.Visible = false;
            // 
            // lbinDiem
            // 
            this.lbinDiem.AutoSize = true;
            this.lbinDiem.Font = new System.Drawing.Font("Stencil Std", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinDiem.ForeColor = System.Drawing.Color.IndianRed;
            this.lbinDiem.Location = new System.Drawing.Point(171, 192);
            this.lbinDiem.Name = "lbinDiem";
            this.lbinDiem.Size = new System.Drawing.Size(72, 79);
            this.lbinDiem.TabIndex = 8;
            this.lbinDiem.Text = "0";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Menu.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.Red;
            this.Menu.Location = new System.Drawing.Point(244, 346);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(130, 67);
            this.Menu.TabIndex = 7;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // nutPlay
            // 
            this.nutPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nutPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nutPlay.BackgroundImage")));
            this.nutPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nutPlay.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.nutPlay.Location = new System.Drawing.Point(46, 346);
            this.nutPlay.Name = "nutPlay";
            this.nutPlay.Size = new System.Drawing.Size(121, 67);
            this.nutPlay.TabIndex = 6;
            this.nutPlay.UseVisualStyleBackColor = false;
            this.nutPlay.Click += new System.EventHandler(this.nutPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(71, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "NORMAI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(81, 134);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(87, 83);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // Play
            // 
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(923, 2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(53, 50);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 13;
            this.Play.TabStop = false;
            this.Play.Visible = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Dung
            // 
            this.Dung.Image = ((System.Drawing.Image)(resources.GetObject("Dung.Image")));
            this.Dung.Location = new System.Drawing.Point(923, 2);
            this.Dung.Name = "Dung";
            this.Dung.Size = new System.Drawing.Size(53, 50);
            this.Dung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dung.TabIndex = 12;
            this.Dung.TabStop = false;
            this.Dung.Click += new System.EventHandler(this.Dung_Click);
            // 
            // pipeD2
            // 
            this.pipeD2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeD2.BackgroundImage")));
            this.pipeD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeD2.Location = new System.Drawing.Point(935, 506);
            this.pipeD2.Name = "pipeD2";
            this.pipeD2.Size = new System.Drawing.Size(84, 999);
            this.pipeD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeD2.TabIndex = 4;
            this.pipeD2.TabStop = false;
            this.pipeD2.Tag = "pipe";
            // 
            // pipeT2
            // 
            this.pipeT2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeT2.BackgroundImage")));
            this.pipeT2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeT2.Location = new System.Drawing.Point(935, -627);
            this.pipeT2.Name = "pipeT2";
            this.pipeT2.Size = new System.Drawing.Size(84, 962);
            this.pipeT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeT2.TabIndex = 3;
            this.pipeT2.TabStop = false;
            this.pipeT2.Tag = "";
            // 
            // pipeT1
            // 
            this.pipeT1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeT1.BackgroundImage")));
            this.pipeT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeT1.Location = new System.Drawing.Point(482, -745);
            this.pipeT1.Name = "pipeT1";
            this.pipeT1.Size = new System.Drawing.Size(84, 962);
            this.pipeT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeT1.TabIndex = 2;
            this.pipeT1.TabStop = false;
            this.pipeT1.Tag = "";
            // 
            // pipeD1
            // 
            this.pipeD1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeD1.BackgroundImage")));
            this.pipeD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeD1.Location = new System.Drawing.Point(482, 390);
            this.pipeD1.Name = "pipeD1";
            this.pipeD1.Size = new System.Drawing.Size(84, 999);
            this.pipeD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeD1.TabIndex = 1;
            this.pipeD1.TabStop = false;
            this.pipeD1.Tag = "pipe";
            // 
            // Tenlua2
            // 
            this.Tenlua2.BackColor = System.Drawing.Color.Transparent;
            this.Tenlua2.Image = ((System.Drawing.Image)(resources.GetObject("Tenlua2.Image")));
            this.Tenlua2.Location = new System.Drawing.Point(1177, 236);
            this.Tenlua2.Name = "Tenlua2";
            this.Tenlua2.Size = new System.Drawing.Size(105, 111);
            this.Tenlua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tenlua2.TabIndex = 6;
            this.Tenlua2.TabStop = false;
            this.Tenlua2.Tag = "TenLua";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(482, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 999);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 604);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Dung);
            this.Controls.Add(this.grEnd);
            this.Controls.Add(this.pipeD2);
            this.Controls.Add(this.pipeT2);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.pipeT1);
            this.Controls.Add(this.pipeD1);
            this.Controls.Add(this.Tenlua2);
            this.Name = "Form1";
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.grEnd.ResumeLayout(false);
            this.grEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tenlua2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeD1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeT1;
        private System.Windows.Forms.PictureBox pipeT2;
        private System.Windows.Forms.PictureBox pipeD2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.PictureBox Tenlua2;
        private System.Windows.Forms.GroupBox grEnd;
        private System.Windows.Forms.Button nutPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Label lbinDiem;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox Dung;
    }
}

