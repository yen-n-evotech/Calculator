using System;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// 一番の数値
        /// </summary>
        private double Num1 = 0;

        /// <summary>
        /// 二番の数値
        /// </summary>
        private double Num2 = 0;

        /// <summary>
        /// 計算符号
        /// </summary>
        private string Calc = "";

        /// <summary>
        /// 複数の「＝」を押す場合、連続計算の計算符号
        /// </summary>
        private string NextCalc = "";

        /// <summary>
        /// 計算符号を選択するか確認
        /// </summary>
        private bool IsOperationSelected = false;

        /// <summary>
        /// 計算のリセットするか確認
        /// </summary>
        private bool IsCleared = false;

        /// <summary>
        /// 点があるか確認
        /// </summary>
        private bool IsExitPoint = false;

        /// <summary>
        /// 「=」という符号をクリックするか確認
        /// </summary>
        private bool IsEqualPressed = false;

        /// <summary>
        /// 連続計算で「＝」の後NumberButtonをクリックするか確認
        /// </summary>
        private bool IsNumberPressedAfterEqual = false;

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
            // すべてのボタンが有効になます。
            EnableButtons();

            // 押したボタンの値を初期化
            Button number = (Button)sender;

            // displayTextに数値を追加して変更
            UpdateDisplayText(number.Text);

            // 計算符号を押せるために、IsOperationSelectedのfalseをセット
            IsOperationSelected = false;

            // 「＝」を押して後、数を押すと、後の計算のためその数値を取ります。
            GetNumberAfterEqual();
        }

        /// <summary>
        /// displayTextに数値を追加して変更
        /// </summary>
        /// <param name="numberText">数値</param>
        private void UpdateDisplayText(string numberText)
        {
            // デフォルトの場合、リセットの場合、エラーの場合、クリックした数値だけを表示。リセットして、displayTextが「0.」または「-0.」の場合、displaytextに追加
            // その以外、2番目の数値以上をクリックして、displayTextに追加される
            if (displayText.Text == "0" || IsCleared == true || displayText.Text == "NaN")
            {
                if (IsCleared == true && (displayText.Text == "0." || displayText.Text == "-0."))
                {
                    displayText.Text += numberText;
                    IsExitPoint = true;
                }
                else
                {
                    displayText.Text = numberText;
                }
                IsCleared = false;
                IsExitPoint = false;
            }
            else
            {
                displayText.Text += numberText;
            }
        }

        /// <summary>
        /// 「＝」を押して後、数を押すと、後の計算のためその数値を取ります。
        /// </summary>
        private void GetNumberAfterEqual()
        {
            // 「＝」を押して後、数を入力できます。数を押すと、後の計算のためその数値を取ります。
            if (IsEqualPressed == true)
            {
                IsNumberPressedAfterEqual = true;
            }
            else
            {
                IsEqualPressed = false;
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
            number = Double.Parse(displayText.Text);

            // 記号ボタンを押すと、数字は普通に符号を変えります。
            DisplayNegative(number);
        }

        /// <summary>
        /// 普通に符号を変えります。
        /// </summary>
        /// <param name="number">数値</param>
        private void DisplayNegative(double number)
        {
            if (IsExitPoint == false)
            {
                number *= (-1);
                displayText.Text = number.ToString();
            }
            else if (displayText.Text.Contains(".") && displayText.Text.Contains("-"))
            {
                displayText.Text = displayText.Text.Substring(1);
            }
            else if (displayText.Text.Contains(".") && !displayText.Text.Contains("-"))
            {
                displayText.Text = "-" + displayText.Text;
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

            // 数値を表示
            DisplayPercentNumber(number);
        }

        /// <summary>
        /// パーセントを押して数値を表示
        /// </summary>
        /// <param name="number">数値</param>
        private void DisplayPercentNumber(double number)
        {
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
                IsExitPoint = true;
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
            if (IsEqualPressed == false && !displayText.Text.Contains("E"))
            {
                // エラーの場合、Delボタンを押すと、リセットになります。他の場合、最初の文字を削除します。
                if (displayText.Text == "NaN")
                {
                    displayText.Text = "0";
                    EnableButtons();
                }
                else if (displayText.Text != "")
                {
                    // 一文字だけがある場合、マイナス符号と一文字だけがある場合、「0」にリセット
                    if (displayText.Text.Length == 1 || ((displayText.Text.Contains("-") && displayText.Text.Length == 2)))
                    {
                        displayText.Text = "0";
                        IsExitPoint = false;
                    }
                    else
                    {
                        // 最終の文字を削除
                        displayText.Text = displayText.Text.Remove(displayText.TextLength - 1);

                        // 削除したら、結果は点がない場合、もう一度点を追加できます。
                        if (!displayText.Text.Contains("."))
                        {
                            IsExitPoint = false;
                        }
                    }
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

            // displayTextで「E」がある場合、結果が表示される場合、PointButtonは無効
            if (!displayText.Text.Contains("E") && IsEqualPressed == false)
            {
                // displayTextは点がまだない場合、点を追加できます。
                if (!displayText.Text.Contains("."))
                {
                    displayText.Text += pointBtn.Text;
                    IsExitPoint = true;
                }
                else
                {
                    IsExitPoint = true;
                }
            }
        }

        /// <summary>
        /// クリアーエベント。クリアーボタンを押すと、リセットになります。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClicked(object sender, EventArgs e)
        {
            // Clearボタンを押すと、すべてのバトンは有効になります。
            EnableButtons();
            displayText.Text = "0";
            Num1 = 0;
            Num2 = 0;
            IsExitPoint = false;
            Calc = "";
            NextCalc = "";
            IsOperationSelected = false;
            IsEqualPressed = false;
            IsNumberPressedAfterEqual = false;
            IsCleared = true;
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
            if (displayText.Text != "NaN")
            {
                // 計算が選択されているかどうかを確認。
                // IsOperationSelected が false の場合、計算が選択されていないことを意味するため、計算ボタンが押されると、現在の結果 (存在する場合) と新しい演算子を使用して計算が実行されます。
                // IsOperationSelected が true の場合、選択された計算がすでに存在することを意味するため、新しい計算ボタンを押すと、古い演算子が新しい演算子で上書きされます。
                if (IsOperationSelected == false)
                {
                    PerformCalculation(Calc);
                    Calc = btn.Text;
                    IsOperationSelected = true;
                    //IsCleared = true;
                }
                else
                {
                    Calc = btn.Text;
                }
                IsEqualPressed = false;
            }
        }

        /// <summary>
        /// = 符号をクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButtonClicked(object sender, EventArgs e)
        {
            // エラー場合、= を押すと、リセットになります。その以外、計算します。
            if (displayText.Text == "NaN")
            {
                displayText.Text = "0";
                EnableButtons();
                IsCleared = true;
                IsEqualPressed = false;
            }
            else
            {
                // 「＝」を一回だけ押すと、計算して、2回以上押すと、連続計算します。
                if (IsEqualPressed == false)
                {
                    // 計算
                    Calculate();
                }
                else
                {
                    // 連続計算
                    CalculateContinious();
                }
            }
        }

        /// <summary>
        /// 計算メソッド
        /// </summary>
        private void Calculate()
        {
            // 計算符号を押す場合、普通に計算します。計算符号を押さないい場合、入力した数を表示
            if (Calc == "+" || Calc == "-" || Calc == "x" || Calc == "/")
            {
                PerformCalculation(Calc);
                IsOperationSelected = false;
                IsCleared = true;
                NextCalc = Calc;
                Calc = "";
                IsEqualPressed = true;
                IsNumberPressedAfterEqual = false;
            }
            else
            {
                Num1 = double.Parse(displayText.Text);
                displayText.Text = Num1.ToString();
                IsCleared = true;
                IsEqualPressed = false;
            }
        }

        /// <summary>
        /// 連続計算
        /// </summary>
        private void CalculateContinious()
        {
            // 複数の「＝」を押すと、数ボタンを押さない場合、普通に計算します。数ボタンを押す場合、たった今押した数値と計算し続きます。
            if (IsNumberPressedAfterEqual == false)
            {
                PerformEqualCalculation(NextCalc, Num2);
                IsEqualPressed = true;
                IsNumberPressedAfterEqual = true;
            }
            else
            {
                Num1 = double.Parse(displayText.Text);
                PerformEqualCalculation(NextCalc, Num2);
                IsEqualPressed = true;
            }
        }

        /// <summary>
        /// 計算メソッド
        /// </summary>
        /// <param name="Calc">計算符号</param>
        private void PerformCalculation(string Calc)
        {
            // エラーがない場合、計算します。
            if (displayText.Text != "NaN")
            {
                Num2 = double.Parse(displayText.Text);

                // 計算します。
                PerformOperation(Calc);

                // 結果を表示
                DisplayResult();
            }
        }

        /// <summary>
        /// 計算した複数の「＝」を押す計算
        /// </summary>
        /// <param name="NextCalc">複数の「＝」を押すと連続計算符号</param>
        /// <param name="repeatValue">２番目の数値</param>
        private void PerformEqualCalculation(string NextCalc, double? repeatValue = null)
        {
            // エラーがない場合、計算します。
            if (displayText.Text != "NaN")
            {
                // 計算します。
                PerformOperation(NextCalc);

                // 結果を表示
                DisplayResult();
            }
        }

        /// <summary>
        /// 計算するメソッド
        /// </summary>
        /// <param name="operation">計算符号</param>
        private void PerformOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                    Num1 += Num2;
                    break;
                case "-":
                    Num1 -= Num2;
                    break;
                case "x":
                    Num1 *= Num2;
                    break;
                case "/":
                    if (Num2 != 0)
                    {
                        Num1 /= Num2;
                    }

                    // num 1 = 0 の場合、エラーが発生
                    else
                    {
                        Num1 = double.NaN;
                        Num2 = double.NaN;
                        displayText.Text = "NaN";
                        DisableButtons();
                    }
                    break;
                default:
                    Num1 = Num2;
                    break;
            }
        }

        /// <summary>
        /// 結果を表示
        /// </summary>
        private void DisplayResult()
        {
            displayText.Text = Convert.ToString(Num1);
            IsCleared = true;
            IsOperationSelected = false;
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
            double result = double.Parse(displayText.Text);

            // 最小値と最大値を設定
            if (result >= double.MinValue && result <= double.MaxValue)
            {
                // displayTextの最長は15文字だので、16文字以上場合、文字列を切り詰めます。「E」がある場合、そのまま計算します。
                if (!displayText.Text.Contains("E"))
                {
                    if (text.Length > maxLength)
                    {
                        // 15文字のdisplayTextに「-」があっても最後の文字は変わりません。
                        if (text.StartsWith("-"))
                        {
                            displayText.Text = "-" + text.Substring(1, maxLength);
                        }
                        else if (text.EndsWith("."))
                        {
                            displayText.Text = text.Substring(0, maxLength - 1);
                        }
                        else
                        {
                            displayText.Text = text.Substring(0, maxLength);
                        }
                        displayText.SelectionStart = displayText.Text.Length;
                    }
                }
            }
            else
            {
                displayText.Text = "NaN";
                DisableButtons();
            }
        }

        /// <summary>
        /// エラーが発生された場合、いつかボタンは無効化にするメソッド
        /// </summary>
        private void DisableButtons()
        {
            percentButton.Enabled = false;
            pointButton.Enabled = false;
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
            signButton.Enabled = true;
            addButton.Enabled = true;
            subtractButton.Enabled = true;
            multiplyButton.Enabled = true;
            devideButton.Enabled = true;
        }

        /// <summary>
        /// キャレットなし表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayTextEnter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
