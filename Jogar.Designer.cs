namespace JogoPacMan
{
    partial class Jogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonJogar = new System.Windows.Forms.Button();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonJogar
            // 
            this.buttonJogar.BackColor = System.Drawing.Color.Black;
            this.buttonJogar.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonJogar.ForeColor = System.Drawing.Color.White;
            this.buttonJogar.Location = new System.Drawing.Point(332, 284);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(136, 35);
            this.buttonJogar.TabIndex = 1;
            this.buttonJogar.Text = "Jogar";
            this.buttonJogar.UseVisualStyleBackColor = false;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // pacman
            // 
            this.pacman.Image = global::JogoPacMan.Properties.Resources.right;
            this.pacman.Location = new System.Drawing.Point(224, 361);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(36, 42);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 2;
            this.pacman.TabStop = false;
            // 
            // pinkGhost
            // 
            this.pinkGhost.Image = global::JogoPacMan.Properties.Resources.pink_guy;
            this.pinkGhost.Location = new System.Drawing.Point(332, 361);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(36, 42);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 3;
            this.pinkGhost.TabStop = false;
            // 
            // redGhost
            // 
            this.redGhost.Image = global::JogoPacMan.Properties.Resources.red_guy;
            this.redGhost.Location = new System.Drawing.Point(435, 361);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(36, 42);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 4;
            this.redGhost.TabStop = false;
            // 
            // yellowGhost
            // 
            this.yellowGhost.Image = global::JogoPacMan.Properties.Resources.yellow_guy;
            this.yellowGhost.Location = new System.Drawing.Point(546, 361);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(36, 42);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 5;
            this.yellowGhost.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::JogoPacMan.Properties.Resources.coin;
            this.pictureBox7.Location = new System.Drawing.Point(290, 371);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(18, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::JogoPacMan.Properties.Resources.coin;
            this.pictureBox8.Location = new System.Drawing.Point(388, 371);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(18, 18);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::JogoPacMan.Properties.Resources.coin;
            this.pictureBox9.Location = new System.Drawing.Point(497, 371);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(18, 18);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // Jogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.buttonJogar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jogar";
            this.Text = "Jogar";
            this.Load += new System.EventHandler(this.Jogar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonJogar;
        private PictureBox pacman;
        private PictureBox pinkGhost;
        private PictureBox redGhost;
        private PictureBox yellowGhost;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
    }
}