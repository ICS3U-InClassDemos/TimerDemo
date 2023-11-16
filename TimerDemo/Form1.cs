using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TimerDemo
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            countLabel.Text = $"{counter}";
            
            if (counter % 3 == 0)
            {
                if (colourLabel.BackColor == Color.White)
                {
                    colourLabel.BackColor = Color.Red;
                }
                else if (colourLabel.BackColor == Color.Red)
                {
                    colourLabel.BackColor = Color.Green;
                }
                else
                {
                    colourLabel.BackColor = Color.White;
                }
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!countTimer.Enabled)
            {
                countTimer.Enabled = true;

                myWatch.Reset();    
                myWatch.Start();
            }
            else
            {
                countTimer.Enabled = false;

                myWatch.Stop();
               // timeLabel.Text = myWatch.Elapsed + "";
               // timeLabel.Text = myWatch.ElapsedMilliseconds + "";
                timeLabel.Text = myWatch.Elapsed.ToString(@"ss\:ff");

            }
        }
    }
}
