using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Fool_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.label1.Text = " hahahaha..... you are a Fool.";
            //this.BackgroundImage = global::Fool_Game.Properties.Resources.DSC_0462;
            
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.label1.Text = " You are not a Fool";
        }

        private void ButtonNoMoving(object sender, EventArgs e)
        {
            Random r = new Random();
            this.button2.Location = new Point(r.Next(this.Width - this.button2.Width), r.Next(this.Height - 80));
        }
        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
