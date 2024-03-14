using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPacMan
{
    public partial class FormLogin : Form
    {

        int  redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;

        private void buttonConfirmar_Click_1(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Diogo" && textBoxPassword.Text == "diogo")
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }

            if (textBoxUsername.Text == "Mini" && textBoxPassword.Text == "mini")
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }

            if (textBoxUsername.Text == "Joca" && textBoxPassword.Text == "joca")
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }

            if (textBoxUsername.Text == "Gonçalo" && textBoxPassword.Text == "gonçalo")
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            redGhost.Left += redGhostSpeed;

            if (redGhost.Bounds.IntersectsWith(pictureBox1.Bounds) || (redGhost.Bounds.IntersectsWith(yellowGhost.Bounds)))
            {
                redGhostSpeed = -redGhostSpeed;
            }

            yellowGhost.Left -= yellowGhostSpeed;

            if (yellowGhost.Bounds.IntersectsWith(redGhost.Bounds) || (yellowGhost.Bounds.IntersectsWith(pinkGhost.Bounds)))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
            }

            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;

            if (pinkGhost.Top < 0 || pinkGhost.Top > 520)
            {
                pinkGhostY = -pinkGhostY;
            }

            if (pinkGhost.Left < 0 || pinkGhost.Left > 620)
            {
                pinkGhostX = -pinkGhostX;
            }
        }
    }
}
