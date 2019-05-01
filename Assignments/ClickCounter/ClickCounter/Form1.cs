using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class Form1 : Form
    {
        int scoring = 0;
        Random r = new Random();
        int staring;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Mouseclickall_Button1(object sender, MouseEventArgs e)
        {
            //scoring++;
            //label2.Text = scoring.ToString();
            if (this.button1.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button1.BackColor != Color.Red)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
            
            

        }

        private void Mouseclickall_Button2(object sender, MouseEventArgs e)
        {
            if (this.button2.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button2.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }

        }

        private void Mouseclickall_Button3(object sender, MouseEventArgs e)
        {
            if (this.button3.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button3.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
        }

        private void Mouseclickall_Button4(object sender, MouseEventArgs e)
        {
            if (this.button4.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button4.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
        }

        private void Mouseclickall_Button5(object sender, MouseEventArgs e)
        {
            if (this.button5.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button5.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
        }

        private void Mouseclickall_Button6(object sender, MouseEventArgs e)
        {
            if (this.button6.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button6.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
        }

        private void Mouseclickall_Button7(object sender, MouseEventArgs e)
        {
            if (this.button7.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button7.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
        }

        private void Mouseclickall_Button8(object sender, MouseEventArgs e)
        {
            if (this.button8.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button8.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
        }

        private void Mouseclickall_Button9(object sender, MouseEventArgs e)
        {
            if (this.button9.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button9.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
        }

        private void Mouseclickall_Button10(object sender, MouseEventArgs e)
        {
            if (this.button10.BackColor == Color.DarkRed)
            {
                scoring=scoring+20;
                label2.Text = scoring.ToString();
            }

            else if (this.button10.BackColor != Color.DarkRed)
            {
                scoring=scoring-30;
                label2.Text = scoring.ToString();
            }
        }
        public void  ColorChanging()
        {

              button1.BackColor = Color.Chocolate;
              button2.BackColor = Color.Chocolate;
              button3.BackColor = Color.Chocolate;
              button4.BackColor = Color.Chocolate;
              button5.BackColor = Color.Chocolate;
              button6.BackColor = Color.Chocolate;
              button7.BackColor = Color.Chocolate;
              button8.BackColor = Color.Chocolate;
              button9.BackColor = Color.Chocolate;
              button10.BackColor = Color.Chocolate;

              staring = r.Next(1, 10);
              if (staring == Convert.ToInt32(button1.Tag))
            {
                button1.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }

              if (staring == Convert.ToInt32(button2.Tag))
            {

                button2.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }

              if (staring == Convert.ToInt32(button3.Tag))
            {
                button3.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }

              if (staring == Convert.ToInt32(button4.Tag))
            {
                button4.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }

              if (staring == Convert.ToInt32(button5.Tag))
            {
                button5.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }


              if (staring == Convert.ToInt32(button6.Tag))
            {
                button6.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }

              if (staring == Convert.ToInt32(button7.Tag))
            {
                button7.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }

              if (staring == Convert.ToInt32(button8.Tag))
            {
                button8.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }

              if (staring == Convert.ToInt32(button9.Tag))
            {
                button9.BackColor = Color.DarkRed;
                timer1.Interval = 1000;

            }

              if (staring == Convert.ToInt32(button10.Tag))
            {
                button10.BackColor = Color.DarkRed;
                timer1.Interval = 1000;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ColorChanging();
        }

        private void buttonExit_click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        }
  
    }


