namespace Game1
{
    partial class Game2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDiem = new System.Windows.Forms.Label();
            this.grEnd = new System.Windows.Forms.GroupBox();
            this.Menu = new System.Windows.Forms.Button();
            this.nutPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInDiem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.tenLua = new System.Windows.Forms.PictureBox();
            this.Dung = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.grEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenLua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
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
            this.lbDiem.Location = new System.Drawing.Point(53, 18);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(48, 53);
            this.lbDiem.TabIndex = 8;
            this.lbDiem.Text = "0";
            // 
            // grEnd
            // 
            this.grEnd.BackColor = System.Drawing.Color.Silver;
            this.grEnd.Controls.Add(this.Menu);
            this.grEnd.Controls.Add(this.nutPlay);
            this.grEnd.Controls.Add(this.label2);
            this.grEnd.Controls.Add(this.lbInDiem);
            this.grEnd.Controls.Add(this.label3);
            this.grEnd.Location = new System.Drawing.Point(282, 57);
            this.grEnd.Name = "grEnd";
            this.grEnd.Size = new System.Drawing.Size(427, 467);
            this.grEnd.TabIndex = 9;
            this.grEnd.TabStop = false;
            this.grEnd.Visible = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Menu.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.Red;
            this.Menu.Location = new System.Drawing.Point(231, 346);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(143, 67);
            this.Menu.TabIndex = 7;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // nutPlay
            // 
            this.nutPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nutPlay.BackgroundImage = global::Game1.Properties.Resources.nutPlay;
            this.nutPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nutPlay.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.nutPlay.Location = new System.Drawing.Point(24, 346);
            this.nutPlay.Name = "nutPlay";
            this.nutPlay.Size = new System.Drawing.Size(143, 67);
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
            // lbInDiem
            // 
            this.lbInDiem.AutoSize = true;
            this.lbInDiem.Font = new System.Drawing.Font("Stencil Std", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInDiem.ForeColor = System.Drawing.Color.IndianRed;
            this.lbInDiem.Location = new System.Drawing.Point(168, 198);
            this.lbInDiem.Name = "lbInDiem";
            this.lbInDiem.Size = new System.Drawing.Size(72, 79);
            this.lbInDiem.TabIndex = 5;
            this.lbInDiem.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 57);
            this.label3.TabIndex = 0;
            this.label3.Text = "GAME OVER";
            // 
            // pipe2
            // 
            this.pipe2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipe2.BackgroundImage")));
            this.pipe2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipe2.Location = new System.Drawing.Point(920, 231);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(84, 250);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipe2.TabIndex = 4;
            this.pipe2.TabStop = false;
            this.pipe2.Tag = "pipe";
            // 
            // pipe1
            // 
            this.pipe1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipe1.BackgroundImage")));
            this.pipe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipe1.Location = new System.Drawing.Point(484, 89);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(84, 250);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipe1.TabIndex = 3;
            this.pipe1.TabStop = false;
            this.pipe1.Tag = "pipe";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.BackgroundImage = global::Game1.Properties.Resources.ai_remove_image;
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Location = new System.Drawing.Point(59, 201);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(92, 88);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // tenLua
            // 
            this.tenLua.BackColor = System.Drawing.Color.Transparent;
            this.tenLua.Image = global::Game1.Properties.Resources.chimden;
            this.tenLua.Location = new System.Drawing.Point(1110, 274);
            this.tenLua.Name = "tenLua";
            this.tenLua.Size = new System.Drawing.Size(86, 82);
            this.tenLua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tenLua.TabIndex = 7;
            this.tenLua.TabStop = false;
            this.tenLua.Tag = "TenLua";
            // 
            // Dung
            // 
            this.Dung.Image = global::Game1.Properties.Resources.NutDungPlay;
            this.Dung.Location = new System.Drawing.Point(892, -1);
            this.Dung.Name = "Dung";
            this.Dung.Size = new System.Drawing.Size(53, 50);
            this.Dung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dung.TabIndex = 10;
            this.Dung.TabStop = false;
            this.Dung.Click += new System.EventHandler(this.Dung_Click);
            // 
            // Play
            // 
            this.Play.Image = global::Game1.Properties.Resources.nutPlay;
            this.Play.Location = new System.Drawing.Point(892, -1);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(53, 50);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 11;
            this.Play.TabStop = false;
            this.Play.Visible = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 604);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Dung);
            this.Controls.Add(this.grEnd);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.tenLua);
            this.Name = "Game2";
            this.Text = "Game2";
            this.Load += new System.EventHandler(this.Game2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.grEnd.ResumeLayout(false);
            this.grEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenLua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox tenLua;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.GroupBox grEnd;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button nutPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Dung;
        private System.Windows.Forms.PictureBox Play;
    }
}