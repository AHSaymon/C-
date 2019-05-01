namespace ClickCounter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 43);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 43);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 43);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button3);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 43);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button4);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 43);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button5);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(144, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 43);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button6);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(40, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 43);
            this.button7.TabIndex = 7;
            this.button7.Tag = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button7);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(144, 188);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 43);
            this.button8.TabIndex = 8;
            this.button8.Tag = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button8);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(40, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 43);
            this.button9.TabIndex = 9;
            this.button9.Tag = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button9);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(144, 237);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 43);
            this.button10.TabIndex = 10;
            this.button10.Tag = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouseclickall_Button10);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Score :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(284, 244);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 36);
            this.button11.TabIndex = 26;
            this.button11.Text = "Exit";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.buttonExit_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(272, 188);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(101, 39);
            this.button12.TabIndex = 27;
            this.button12.Text = "Restart";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 347);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

