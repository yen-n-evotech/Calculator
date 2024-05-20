using System;
using System.Threading;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        double num1= 0, num2 = 0;
        string calc = "+";
        bool selectCheck = false;
        bool clearCheck = false;
        bool pointCheck = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {            
            Button number = (Button)sender;  // 押したボタンの値を初期化
            if (displayText.Text == "0")
            {
                displayText.Clear();
            }
            if (clearCheck == false)
            {
                displayText.Text += number.Text;
            }
            else
            {
                displayText.Text = number.Text;
                clearCheck = false;
                pointCheck = false;
            }
            selectCheck = false;
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
            if (number != 0)
            {
                pointCheck = true;
            }
        }
        
        private void CalcBtnClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (displayText.Text != "0")
            {
                if (selectCheck == false)
                {
                    PerformCalculation(calc);
                    calc = btn.Text;
                    selectCheck = true;
                    clearCheck = true;
                }  
                else
                {
                    calc = btn.Text;
                }
            }        
        }
        
        private void EqualBtnClicked(object sender, EventArgs e)
        {
            if (displayText.Text != "0")
            {
                PerformCalculation(calc);
                selectCheck = false;
                clearCheck = true;
                num2 = 0;
                calc = "+";
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

        private void PointButtonClicked(object sender, EventArgs e)
        {
            Button pointBtn = (Button)sender;
            if (pointCheck == false)
            {
                displayText.Text += pointBtn.Text;
                pointCheck = true;
            }
        }

        private void ClearBtnClicked(object sender, EventArgs e)
        {
            displayText.Text = "0";
            num1 = 0;
            num2 = 0;
        }

        private void PerformCalculation (string calc)
        {
            num1 = Double.Parse(displayText.Text);
            switch (calc)
            {
                case "+":
                    num2 += num1;
                    break;
                case "-":
                    num2 -= num1;
                    break;
                case "x":
                    num2 *= num1;
                    break;
                case "/":
                    num2 /= num1;
                    break;
                default:
                    break;
            }
            displayText.Text = Convert.ToString(num2);

        }
    }
}
