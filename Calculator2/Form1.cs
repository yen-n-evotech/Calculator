using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        double result = 0;
        private object calc;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {
            Button number = (Button)sender;  //押したボタンの値を初期化

            if (number.Text == ".")
            {
                if (!displayText.Text.Contains(".")) // "."が一回だけ表示できる
                {
                    displayText.Text += ".";
                }
            }
            else
            {
                displayText.Text = displayText.Text + number.Text;
            }          
        }

        private void SignBtnClicked(object sender, EventArgs e)
        {
            double number;
            number = Convert.ToDouble(displayText.Text) * (-1.0);
        }

        private void CalcBtnClicked(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            calc = Convert.ToDouble(number.Text);
            result = Convert.ToDouble(displayText);
        }

        private void equalBtnClicked(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            switch(calc)
            {
                //case "+":
                    
            }
        }
    }
}
