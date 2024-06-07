using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace installation
{
    public partial class Form1 : Form
    {
        private int percentage = 0;
        Random rnd1 = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ProgressLabel(int addby)
        {
            percentage = percentage + addby;
            this.label3.Text = percentage.ToString() + "% complete";
            if (percentage > 99)
            {
                this.label3.Text = "100% complete";
                this.label4.Text = "you dont need help now since you won but PLEASE visit https://nswishball.github.io";
                Cursor.Show();
                pictureBox1.Hide();
                pictureBox2.Show();
                this.BackColor = Color.FromArgb(0, 0, 0);
                MessageBox.Show("YOU DID IT!!! :D\nNOW ILL LET YOU FREE!!", "goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            pictureBox2.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int randomnumber = rnd1.Next(1,10);
            ProgressLabel(randomnumber);
        }
    }
}
