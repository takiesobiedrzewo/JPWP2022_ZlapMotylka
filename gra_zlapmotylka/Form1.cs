using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra_zlapmotylka
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int locationNum = 0;
        int points = 0;
        int lifes = 3;
        bool isClicked = false;
        bool isBlue = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void gotButterfly(object sender, EventArgs e)
        {
            if (isBlue == true)
            {
                points++;

                isClicked = true;

                butterfly.Enabled = false;
            }
        }

        private void moveButterfly(object sender, EventArgs e)
        {
            lblLife.Text = "Zycia " + lifes;
            lblPoints.Text = "Punkty:" + points;
            if ((isClicked == false && isBlue == true) || (isClicked == true && isBlue == false))
            {
                lifes--;
            }
            if (points > 15)
            {
                timer1.Stop();
                butterfly.Enabled = false;
                MessageBox.Show("You Win");
            }
            else if (lifes < 0)
            {
                timer1.Stop();
                butterfly.Enabled = false;
                MessageBox.Show("You Lose");

            }

            moveButterfly();
        }
        private void moveButterfly()
        {   
            isClicked = false;
            butterfly.Enabled = true;
            locationNum = rnd.Next(2);
            if (locationNum == 1)
            {
                butterfly.Image = Properties.Resources.red;
                isBlue = false;
            }
            else
            {
                butterfly.Image = Properties.Resources.blue;
                isBlue = true;
            }
            butterfly.BackColor = System.Drawing.Color.Transparent;

            locationNum = rnd.Next(1, 7);


            switch (locationNum)
            {
                case 1:
                    butterfly.Left = 434;
                    butterfly.Top = 249;
                    break;

                case 2:
                    butterfly.Left = 257;
                    butterfly.Top = 211;
                    break;

                case 3:
                    butterfly.Left = 58;
                    butterfly.Top = 240;
                    break;

                case 4:
                    butterfly.Left = 85;
                    butterfly.Top = 318;
                    break;

                case 5:
                    butterfly.Left = 254;
                    butterfly.Top = 364;
                    break;

                case 6:
                    butterfly.Left = 416;
                    butterfly.Top = 323;
                    break;

                default:
                    break;
            }
        }


    }
}
