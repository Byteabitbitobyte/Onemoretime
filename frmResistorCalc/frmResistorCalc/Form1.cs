using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmResistorCalc
{
    public partial class Form1 : Form
    {

        private Color[] firstbandsecondband = { Color.Black, Color.Blue, Color.Brown, Color.Gray, Color.Green, Color.Orange, Color.Red, Color.Violet, Color.White, Color.Yellow };

        private Color[] thirdband = { Color.Black, Color.Blue, Color.Brown, Color.Gold, Color.Gray, Color.Green, Color.Orange, Color.Red, Color.Silver, Color.Violet, Color.White, Color.Yellow };

        private Color[] fourband = { Color.Blue, Color.Brown, Color.Gray, Color.Green, Color.Orange, Color.Red, Color.Silver, Color.Violet, Color.Yellow };

        private int[] digit = { 0, 6, 1, 8, 5, 3, 2, 7, 9, 4 };

        private double[] multiplier = {1,10,100,0.1,1,10,100,1000,0.01,0.1,1,10 };

        private double[] tolerance = { 0.0025, 0.01, .05, .0005, .005, .02, 0.1, .001, .05 };

        private void updateValue()
        {
            // if statement to correct error of combo boxes being -1 and breaking
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex < 0 || comboBox4.SelectedIndex < 0)
            {
                return;
            }
            double value = 0;
            value = digit[comboBox1.SelectedIndex]*10 + digit[comboBox2.SelectedIndex];
            value *= multiplier[comboBox3.SelectedIndex];

            double min = value - (value * tolerance[comboBox4.SelectedIndex]);
            double max = value + (value * tolerance[comboBox4.SelectedIndex]);
            minValue.Text = min.ToString();
            maxValue.Text = max.ToString();
            txtValue.Text = value.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBandOne.BackColor = firstbandsecondband[comboBox1.SelectedIndex];
            updateValue();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBandTwo.BackColor = firstbandsecondband[comboBox2.SelectedIndex];
            updateValue();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBandThree.BackColor = thirdband[comboBox3.SelectedIndex];
            updateValue();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBandFour.BackColor = fourband[comboBox4.SelectedIndex];
            updateValue();
        }
    }
}
