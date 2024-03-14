namespace JogoPacMan
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.Black;
            this.buttonConfirmar.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmar.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmar.Location = new System.Drawing.Point(181, 338);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(136, 35);
            this.buttonConfirmar.TabIndex = 0;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click_1);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Black;
            this.buttonCancelar.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(447, 338);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(136, 35);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Black;
            this.textBoxUsername.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(265, 233);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(243, 23);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Black;
            this.textBoxPassword.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(265, 282);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(243, 23);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(338, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 39);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Login";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // yellowGhost
            // 
            this.yellowGhost.Image = global::JogoPacMan.Properties.Resources.yellow_guy;
            this.yellowGhost.Location = new System.Drawing.Point(623, 84);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(36, 42);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 6;
            this.yellowGhost.TabStop = false;
            // 
            // redGhost
            // 
            this.redGhost.Image = global::JogoPacMan.Properties.Resources.red_guy;
            this.redGhost.Location = new System.Drawing.Point(623, 233);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(36, 42);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 7;
            this.redGhost.TabStop = false;
            // 
            // pinkGhost
            // 
            this.pinkGhost.Image = global::JogoPacMan.Properties.Resources.pink_guy;
            this.pinkGhost.Location = new System.Drawing.Point(87, 84);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(36, 42);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 8;
            this.pinkGhost.TabStop = false;
            // 
            // pacman
            // 
            this.pacman.Image = global::JogoPacMan.Properties.Resources.right;
            this.pacman.Location = new System.Drawing.Point(139, 224);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(36, 42);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 9;
            this.pacman.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConfirmar;
        private Button buttonCancelar;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private PictureBox yellowGhost;
        private PictureBox redGhost;
        private PictureBox pinkGhost;
        private PictureBox pacman;
    }
}