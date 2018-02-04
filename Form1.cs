using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckySeven
{
    public partial class Form1 : Form
    {

        
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnEasy.Checked = true;
            this.BackColor = Color.MintCream;
            nightModeButton.BackgroundImage = LuckySeven.Properties.Resources.sun;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            if (rbtnEasy.Checked==true)
            {
                numberOne.Text = rnd.Next(1, 6).ToString();
                numberTwo.Text = rnd.Next(1, 6).ToString();
                numberThree.Text = rnd.Next(1, 6).ToString();
            }
            else if (rbtnMid.Checked==true)
            {
                numberOne.Text = rnd.Next(1,11).ToString();
                numberTwo.Text = rnd.Next(1,11).ToString();
                numberThree.Text = rnd.Next(1,11).ToString();
            }
            else
            {
                numberOne.Text = rnd.Next(1, 16).ToString();
                numberTwo.Text = rnd.Next(1, 16).ToString();
                numberThree.Text = rnd.Next(1, 16).ToString();
            }

            if (numberOne.Text==numberTwo.Text&&numberOne.Text==numberThree.Text)
            {
               MessageBox.Show("You Win !");
                label1.Text = "You Win";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "You Lost!";
                label1.ForeColor = Color.DarkRed;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Select for Sun Mode";
                nightModeButton.BackgroundImage = LuckySeven.Properties.Resources.night;
                checkBox1.ForeColor = Color.DarkSeaGreen;
                this.BackColor = Color.Gray;
                
            }
            else
            {
                checkBox1.Text = "Select for Night Mode";
                this.BackColor = Color.Empty;
                checkBox1.ForeColor = Color.Black;
                nightModeButton.BackgroundImage = LuckySeven.Properties.Resources.sun;
            }
        }
    }
}
