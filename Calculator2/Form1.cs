using System;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        double result = 0;
        string calc = "";

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
                    displayText.Text += number.Text;
                }
            }
            else
            {
                displayText.Text += number.Text;
            }          
        }

        private void SignBtnClicked(object sender, EventArgs e)
        {
            double number;
            number = Double.Parse(displayText.Text) * (-1.0);
            displayText.Text = System.Convert.ToString(number);
        }

        private void PercentBtnClicked(object sender, EventArgs e)
        {
            double number;
            number = Double.Parse(displayText.Text) / (100);
            displayText.Text = System.Convert.ToString(number);
        }

        private void CalcBtnClicked(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            calc = number.Text;
            result = Double.Parse(displayText.Text);
            displayText.Text = "";
            calcShowLabel.Text = System.Convert.ToString(result) + " " + calc;
        }

        private void equalBtnClicked(object sender, EventArgs e)
        {
            calcShowLabel.Text = "";
            switch(calc)
            {
                case "+":
                    displayText.Text = (result + Double.Parse(displayText.Text)).ToString();
                    break;
                case "-":
                    displayText.Text = (result - Double.Parse(displayText.Text)).ToString();
                    break;
                case "x":
                    displayText.Text = (result * Double.Parse(displayText.Text)).ToString(); 
                    break;
                case "/":
                    displayText.Text = (result / Double.Parse(displayText.Text)).ToString();
                    break;
            }
        }

        private void DelBtnClicked(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text.Remove(displayText.TextLength - 1);
        }

        private void ClearBtnClicked(object sender, EventArgs e)
        {
            displayText.Clear();
            calcShowLabel.Text = "";
        }
    }
}
