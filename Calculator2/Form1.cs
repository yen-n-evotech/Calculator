using System;
using System.Threading;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        double num1= 0, num2 = 0;
        double result = 0;
        string calc = "";
        bool operationCheck = false;
        int clickcount = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {            
            if (displayText.Text == "0" || (operationCheck = true))
            {
                displayText.Clear();
            }
            operationCheck = false;
            Button number = (Button)sender;  // 押したボタンの値を初期化
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
            Button btn = (Button)sender;
            if (num1 != 0)
            {
                equalButton.PerformClick();
            }
            calc = btn.Text;
            num1 = Double.Parse(displayText.Text);
            displayText.Text = "";
            calcShowLabel.Text = System.Convert.ToString(num1) + " " + calc;
            operationCheck = true;
        
        }
        
        private void equalBtnClicked(object sender, EventArgs e)
        {
            calcShowLabel.Text = "";
            num2 = Double.Parse(displayText.Text);
            switch(calc) 
            {
                case "+":
                    displayText.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    displayText.Text = (num1 - num2).ToString();
                    break;
                case "x":
                    displayText.Text = (num1 * num2).ToString(); 
                    break;
                case "/":
                    displayText.Text = (num1 / num2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void DelBtnClicked(object sender, EventArgs e)
        {
            if (displayText.Text.Length > 0)
            {
                displayText.Text = displayText.Text.Remove(displayText.TextLength - 1);
            }
            if (displayText.Text == "")
            {
                displayText.Text = "0";
            }
        }

        private void ClearBtnClicked(object sender, EventArgs e)
        {
            displayText.Text = "0";
            num1 = 0;
            num2 = 0;            
            calcShowLabel.Text = "";
        }
    }
}
