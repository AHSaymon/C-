using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = " ";
       
        //Double memo = 0;

        bool operation_press = false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(operation_press))
                textBox1.Clear();
            operation_press = false;
             Button button = (Button)sender;
             if (button.Text == ".")
            { 
               if(!textBox1.Text.Contains("."))
                   textBox1.Text = textBox1.Text + button.Text;
 
            }else

            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(textBox1.Text);
            operation_press = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case"+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
                  
            }
           

            operation_press = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                string text = textBox1.Text.Remove(textBox1.TextLength - 1);
                textBox1.Text = text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Number", "Error Message");
            }
            
        }

        
        
    }



    }


