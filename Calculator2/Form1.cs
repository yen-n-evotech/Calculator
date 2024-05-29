using System;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// 一番の数値
        /// </summary>
        double num1 = 0;

        /// <summary>
        /// 二番の数値
        /// </summary>
        double num2 = 0;

        /// <summary>
        /// 計算符号
        /// </summary>
        string calc = "";

        string nextcalc = "";

        /// <summary>
        /// 計算符号を選択するか確認
        /// </summary>
        bool selectCheck = false;

        /// <summary>
        /// 計算のリセットするか確認
        /// </summary>
        bool clearCheck = false;

        /// <summary>
        /// 点があるか確認
        /// </summary>
        bool pointCheck = false;

        /// <summary>
        /// 「=」という符号をクリックするか確認
        /// </summary>
        bool pressedEqual = false;

        /// <summary>
        /// 連続計算で「＝」の後NumberButtonをクリックするか確認
        /// </summary>
        bool pressNumberAfterEqual = false;

        /// <summary>
        /// 電卓クラスを初期化
        /// </summary>
        public Calculator()
        {
            InitializeComponent();          
        }

        /// <summary>
        /// 数値ボタンをクリックする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberButtonClicked(object sender, EventArgs e)
        {
            EnableButtons();
            Button number = (Button)sender;  // 押したボタンの値を初期化

            // デフォルトの場合、リセットの場合、エラーの場合、クリックした数値だけを表示。リセットして、displayTextが「0.」または「-0.」の場合、displaytextに追加
            // その以外、2番目の数値以上をクリックして、displayTextに追加される
            if (displayText.Text == "0" || clearCheck == true || displayText.Text == "NaN")
            {
                if (clearCheck == true && (displayText.Text == "0." || displayText.Text == "-0."))
                {
                    displayText.Text += number.Text;
                    pointCheck = true;
                }
                else
                {
                    displayText.Text = number.Text;
                }
                clearCheck = false;
                pointCheck = false;
            }
            else
            {
                displayText.Text += number.Text;
            }
            selectCheck = false;
            if (pressedEqual == true)
            {
                pressNumberAfterEqual = true;
            }
            else
            {
                pressedEqual = false;
            }

        }

        /// <summary>
        /// 「+/-」という数字記号を決めるエベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignButtonClicked(object sender, EventArgs e)
        {
            double number;
            number = Double.Parse(displayText.Text) * (-1.0);

            // 記号ボタンを押すと、displayTextが「0.」の場合、「-0.」になり、最後記号が「．」の場合、「．」という符号は削除されません。その以外、数字は普通に符号を変えります。
            if (displayText.Text == "0.")
            {
                displayText.Text = "-0.";
                pointCheck = true;
            }
            else if (displayText.Text.EndsWith("."))
            {                
                displayText.Text = System.Convert.ToString(number) + ".";
            }
            else
            {
                displayText.Text = System.Convert.ToString(number);
            }
        }

        /// <summary>
        /// パーセントのエベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PercentButtonClicked(object sender, EventArgs e)
        {
            double number;
            number = (Double.Parse(displayText.Text) / 100.0);

            // 小数点以下の桁数に基づいて 10 進数をフォーマット
            if (Math.Abs(number) < 1E-10)
            {
                displayText.Text = number.ToString("G10");              
            }
            else 
            {
                displayText.Text = number.ToString("F20").TrimEnd('0').TrimEnd('.');
            }

            // 結果は0と違ったら、小数です。その場合、もう一度点符号を追加できません。
            if (number != 0)
            {
                pointCheck = true;
            }
            else
            {
                displayText.Text = "0";
            }
        }

        /// <summary>
        /// 最後の文字を削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelButtonClicked(object sender, EventArgs e)
        {
            // エラーの場合、Delボタンを押すと、リセットになります。他の場合、最初の文字を削除します。
            if (displayText.Text == "NaN")
            {
                displayText.Text = "0";
                EnableButtons();
            }
            else if (displayText.Text != "")
            {
                // 最終の文字を削除
                displayText.Text = displayText.Text.Remove(displayText.TextLength - 1);

                // テキストが空の場合、またはマイナス記号のみが含まれる場合、「0」にリセット
                if (displayText.Text == "" || (displayText.Text.Contains("-") && displayText.Text.Length < 2))
                {
                    displayText.Text = "0";
                    pointCheck = false;
                }

                // 削除したら、結果は点がない場合、もう一度点を追加できます。
                else if (!displayText.Text.Contains("."))
                {
                    pointCheck = false;
                }
            }
        }

        /// <summary>
        /// 小数の点を追加エベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PointButtonClicked(object sender, EventArgs e)
        {
            Button pointBtn = (Button)sender;
            
            // displayTextは点がまだない場合、点を追加できます。
            if (!displayText.Text.Contains("."))
            {
                displayText.Text += pointBtn.Text;
                pointCheck = true;
            }
            else
            {
                pointCheck = true;
            }
        }

        /// <summary>
        /// クリアーエベント。クリアーボタンを押すと、リセットになります。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClicked(object sender, EventArgs e)
        {
            EnableButtons();
            displayText.Text = "0";
            num1 = 0;
            num2 = 0;                
            pointCheck = false;
            calc = "";
            clearCheck = true;
            pressedEqual = false;
        }

        /// <summary>
        /// 計算符号のエベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // displayTextはエラーない場合、空ない場合、計算できます。
            if (displayText.Text != "" && displayText.Text != "NaN")
            {
                // 計算が選択されているかどうかを確認。
                // selectCheck が false の場合、計算が選択されていないことを意味するため、計算ボタンが押されると、現在の結果 (存在する場合) と新しい演算子を使用して計算が実行されます。
                // selectCheck が true の場合、選択された計算がすでに存在することを意味するため、新しい計算ボタンを押すと、古い演算子が新しい演算子で上書きされます。
                if (selectCheck == false)
                {
                    PerformCalculation(calc);
                    calc = btn.Text;
                    selectCheck = true;
                    //clearCheck = true;
                }
                else
                {
                    calc = btn.Text;
                }
                pressedEqual = false;
            }
        }
        
        /// <summary>
        /// = 符号をクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButtonClicked(object sender, EventArgs e)
        {
            Button equalBtn = (Button)sender;
            // エラー場合、= を押すと、リセットになります。その以外、計算します。
            if (displayText.Text == "NaN")
            {
                displayText.Text = "0";
                EnableButtons();
            }
            else
            {                
                if (pressedEqual == false)
                {
                    //num2 = double.Parse(displayText.Text);
                    if (calc == "+" || calc == "-" || calc == "x" || calc == "/")
                    {
                        PerformCalculation(calc);
                        selectCheck = false;
                        clearCheck = true;
                        nextcalc = calc;
                        calc = "";
                        pressedEqual = true;
                    }
                    else
                    {
                        num1 = double.Parse(displayText.Text);
                        displayText.Text = num1.ToString();
                        clearCheck = true;
                        pressedEqual = false;
                    }
                }
                else
                {     
                    if (pressNumberAfterEqual == false)
                    {
                        PerformEqualCalculation(nextcalc, num2);
                        pressedEqual = true;
                    }
                    else
                    {
                        num1 = double.Parse(displayText.Text);
                        PerformEqualCalculation(nextcalc, num2);
                        pressedEqual = true;
                    }
                }                
            }             
        }

        /// <summary>
        /// 計算メソッド
        /// </summary>
        /// <param name="calc"></param>
        private void PerformCalculation (string calc)
        {
            // エラーがない場合、計算します。
            if (displayText.Text != "NaN")
            {
                num2 = double.Parse(displayText.Text);
                switch (calc)
                {
                    case "+":
                        num1 += num2;
                        break;
                    case "-":
                        num1 -= num2;
                        break;
                    case "x":
                        num1 *= num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            num1 /= num2;
                        }

                        // num 1 = 0 の場合、エラーが発生
                        else
                        {
                            num1 = double.NaN;
                            num2 = double.NaN;
                            displayText.Text = "NaN";
                            DisableButtons();
                        }
                        break;
                    default:
                        num1 = num2;
                        break;
                }
                displayText.Text = Convert.ToString(num1);
                clearCheck = true;
                selectCheck = false;
            }
        }

        private void PerformEqualCalculation(string nextcalc, double? repeatValue = null)
        {
            // エラーがない場合、計算します。
            if (displayText.Text != "NaN")
            {
                switch (nextcalc)
                {
                    case "+":
                        num1 += num2;
                        break;
                    case "-":
                        num1 -= num2;
                        break;
                    case "x":
                        num1 *= num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            num1 /= num2;
                        }

                        // num 1 = 0 の場合、エラーが発生
                        else
                        {
                            num1 = double.NaN;
                            num2 = double.NaN;
                            displayText.Text = "NaN";
                            DisableButtons();
                        }
                        break;
                    default:
                        num1 = num2;
                        break;
                }
                displayText.Text = Convert.ToString(num1);
                clearCheck = true;
                selectCheck = false;
            }
        }

        /// <summary>
        /// displayTextが16文字以上場合、文字列を切り詰めます。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayTextChanged(object sender, EventArgs e)
        {      
            const int maxLength = 15;
            string text = displayText.Text;

            // displayTextの最長は15文字だので、16文字以上場合、文字列を切り詰めます。
            if (text.Length > maxLength)
            {
                if (text.StartsWith("-"))
                {
                    displayText.Text = "-" + text.Substring(1, maxLength);
                }
                else
                {
                    displayText.Text = text.Substring(0, maxLength);
                }

                displayText.SelectionStart = displayText.Text.Length;
            }
        }
        
        /// <summary>
        /// エラーが発生された場合、いつかボタンは無効化にするメソッド
        /// </summary>
        private void DisableButtons()
        {
            percentButton.Enabled = false;
            pointButton.Enabled = false;
            percentButton.Enabled = false;
            signButton.Enabled = false;
            addButton.Enabled = false;
            subtractButton.Enabled = false;
            multiplyButton.Enabled = false; 
            devideButton.Enabled = false;
        }

        /// <summary>
        /// エラー解決のため、有効にするメソッド
        /// </summary>
        private void EnableButtons()
        {
            percentButton.Enabled = true;
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            pointButton.Enabled = true;
            percentButton.Enabled = true;
            signButton.Enabled = true;
            addButton.Enabled = true;
            subtractButton.Enabled = true;
            multiplyButton.Enabled = true;
            devideButton.Enabled = true;
        }
    }
}
