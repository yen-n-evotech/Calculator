using System;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        double num1 = 0;
        double num2 = 0;
        string calc = "";
        bool selectCheck = false;
        bool clearCheck = false;
        bool pointCheck = false;
        bool equalPressedLastCheck = false;

        public Calculator()
        {
            InitializeComponent();
            this.AutoSize = true;
        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {            
            Button number = (Button)sender;  // 押したボタンの値を初期化
            if (displayText.Text == "0" || clearCheck == true || displayText.Text == "NaN")
            {
                displayText.Text = number.Text;
                clearCheck = false;
                pointCheck = false;
            } 
            else
            {
                displayText.Text += number.Text;
            }
            selectCheck = false;
        }

        private void SignButtonClicked(object sender, EventArgs e)
        {
            double number;
            number = Double.Parse(displayText.Text) * (-1.0);
            displayText.Text = System.Convert.ToString(number);
        }

        private void PercentButtonClicked(object sender, EventArgs e)
        {
            double number;
            number = Double.Parse(displayText.Text) / 100.0;

            displayText.Text = number.ToString();

            if (number != 0)
            {
                pointCheck = true;
            }
        }

        private void DelButtonClicked(object sender, EventArgs e)
        {
            if (displayText.Text.Length > 0)
            {
                // 最終の文字を削除
                displayText.Text = displayText.Text.Remove(displayText.TextLength - 1);

                // テキストが空の場合、またはマイナス記号のみが含まれる場合、「0」にリセット
                if (displayText.Text == "" || displayText.Text.Contains("-"))
                {
                    displayText.Text = "0";
                    pointCheck = false;
                }
                else if (!displayText.Text.Contains("."))
                {
                    pointCheck = false;
                }
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

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            displayText.Text = "0";
            num1 = 0;
            num2 = 0;                
            pointCheck = false;
            calc = "";
            equalPressedLastCheck = false;
            clearCheck = false;
        }

        private void CalcButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (displayText.Text != "" && displayText.Text != "NaN")
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
        
        private void EqualButtonClicked(object sender, EventArgs e)
        {
            num1 = double.Parse(displayText.Text);
            if (displayText.Text != "" && displayText.Text != "NaN")
            {
                PerformCalculation(calc);
                selectCheck = false;
                clearCheck = true;
                num2 = 0;
                calc = "+";
            }            
        }

        private void PerformCalculation (string calc)
        {
            num1 = double.Parse(displayText.Text);
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
                    if (num1 != 0)
                    {
                        num2 /= num1;
                    }
                    else
                    {
                        num2 = double.NaN;
                    }
                    break;
                default:
                    num2 = num1;
                    break;
            }
            displayText.Text = Convert.ToString(num2);
        }            
    }
}
