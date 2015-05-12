using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BR2
{
    public partial class Form1 : Form
    {
        int go = 0;
        int shot = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lisa.Location.X <= this.Width - lisa.Width && lisa.Location.Y <= this.Height - lisa.Height && lisa.Location.Y >= 0 && lisa.Location.X >=0)
            {
                if (shot == 1)
                {

                    if (fir.Location.X <= this.Width - fir.Width)
                    {
                        fir.Left += 10;
                    }
                    else {

                        fir.Dispose();
                    
                    }
                    
                }


                if (go == 1)
                    lisa.Top -= 10;
                else if (go == 2)
                    lisa.Top += 10;
                else if (go == 3)
                    lisa.Left += 10;
                else if (go == 4)
                    lisa.Left -= 10;
            }
            else {
                if (go == 1)
                {
                    go = 2;
                    lisa.Top += 10;
                }
                else if (go == 2)
                {
                    go = 1;
                    lisa.Top -= 10;
                }
                else if (go == 3)
                {
                    go = 4;
                    lisa.Left -= 10;
                }
                else if (go == 4)
                {
                    go = 3;
                    lisa.Left += 10;
                }
            
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                go = 1;
            else if (e.KeyCode == Keys.Down)
                go = 2;
            else if (e.KeyCode == Keys.Right)
                go = 3;
            else if (e.KeyCode == Keys.Left)
                go = 4;
            else if (e.KeyCode == Keys.Space) {
                shot = 1;
                fir.Visible = true;
                fir.Location = lisa.Location;
            }
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
