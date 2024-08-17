namespace Game1
{
    partial class StartGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PLAYGAME1 = new System.Windows.Forms.Button();
            this.CAVEGAME2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Amthanh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game1.Properties.Resources.reach;
            this.pictureBox1.Location = new System.Drawing.Point(61, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PLAYGAME1
            // 
            this.PLAYGAME1.Font = new System.Drawing.Font("Cooper Std Black", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYGAME1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.PLAYGAME1.Location = new System.Drawing.Point(129, 154);
            this.PLAYGAME1.Name = "PLAYGAME1";
            this.PLAYGAME1.Size = new System.Drawing.Size(193, 59);
            this.PLAYGAME1.TabIndex = 1;
            this.PLAYGAME1.Text = "PLAY";
            this.PLAYGAME1.UseVisualStyleBackColor = true;
            this.PLAYGAME1.Click += new System.EventHandler(this.PLAYGAME1_Click);
            // 
            // CAVEGAME2
            // 
            this.CAVEGAME2.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAVEGAME2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.CAVEGAME2.Location = new System.Drawing.Point(129, 260);
            this.CAVEGAME2.Name = "CAVEGAME2";
            this.CAVEGAME2.Size = new System.Drawing.Size(193, 59);
            this.CAVEGAME2.TabIndex = 2;
            this.CAVEGAME2.Text = "CAVE";
            this.CAVEGAME2.UseVisualStyleBackColor = true;
            this.CAVEGAME2.Click += new System.EventHandler(this.CAVEGAME2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.Location = new System.Drawing.Point(129, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Amthanh
            // 
            this.Amthanh.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amthanh.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Amthanh.Location = new System.Drawing.Point(129, 372);
            this.Amthanh.Name = "Amthanh";
            this.Amthanh.Size = new System.Drawing.Size(193, 59);
            this.Amthanh.TabIndex = 4;
            this.Amthanh.Text = "Am";
            this.Amthanh.UseVisualStyleBackColor = true;
            this.Amthanh.Click += new System.EventHandler(this.Amthanh_Click);
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 603);
            this.Controls.Add(this.Amthanh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CAVEGAME2);
            this.Controls.Add(this.PLAYGAME1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartGame";
            this.Text = "StartGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PLAYGAME1;
        private System.Windows.Forms.Button CAVEGAME2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Amthanh;
    }
}