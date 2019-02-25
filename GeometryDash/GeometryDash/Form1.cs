using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryDash
{
    public partial class Form1 : Form
    {
        bool jump = false;

        int Gravity = 10;
        int jumpforce = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player.Top += Gravity;
            if (jump && jumpforce < 0 )
            {
                jump = false;
            }
            if (jump)
            {
                Gravity = -10;
                jumpforce = 10;
            }
            else

            //this controls how fast the box is coming down
            {
                Gravity = 12;
            }

            foreach (Control x in this.Controls)

                if (x is PictureBox && x.Tag == "platform")
                    if (Player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        Gravity = 12;
                        Player.Top = x.Top - Player.Height;
                    }
        }

        private void GoDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jump)
            {
                jump = true;
            }
            
            
        } 


        private void GoUp(object sender, KeyEventArgs e)
        {
            if (jump)
            {
                jump = false;
            }
        }

        private void Platform_Click(object sender, EventArgs e)
        {

        }
    }
}