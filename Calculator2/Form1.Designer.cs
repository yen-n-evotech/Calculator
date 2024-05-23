namespace Calculator2
{
    partial class Calculator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.displayText = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonValue = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayText
            // 
            this.displayText.BackColor = System.Drawing.SystemColors.ControlText;
            this.displayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayText.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.displayText.ForeColor = System.Drawing.SystemColors.Window;
            this.displayText.Location = new System.Drawing.Point(12, 27);
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayText.Size = new System.Drawing.Size(338, 43);
            this.displayText.TabIndex = 1;
            this.displayText.Text = "0";
            this.displayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(12, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 62);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(100, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 62);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(188, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 62);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(12, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 62);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(100, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 62);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(188, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 62);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(100, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(188, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // buttonValue
            // 
            this.buttonValue.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonValue.Location = new System.Drawing.Point(12, 350);
            this.buttonValue.Name = "buttonValue";
            this.buttonValue.Size = new System.Drawing.Size(82, 62);
            this.buttonValue.TabIndex = 10;
            this.buttonValue.Text = "+/-";
            this.buttonValue.UseVisualStyleBackColor = false;
            this.buttonValue.Click += new System.EventHandler(this.SignButtonClicked);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button0.Location = new System.Drawing.Point(100, 350);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(82, 62);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPoint.Location = new System.Drawing.Point(188, 350);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(82, 62);
            this.buttonPoint.TabIndex = 12;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.PointButtonClicked);
            // 
            // addButton
            // 
            this.addButton.AccessibleName = "calcBtns";
            this.addButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(276, 350);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 62);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // subtractButton
            // 
            this.subtractButton.AccessibleName = "calcBtns";
            this.subtractButton.BackColor = System.Drawing.Color.DarkOrange;
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtractButton.Location = new System.Drawing.Point(276, 282);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(82, 62);
            this.subtractButton.TabIndex = 14;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // multiplyButton
            // 
            this.multiplyButton.AccessibleName = "calcBtns";
            this.multiplyButton.BackColor = System.Drawing.Color.DarkOrange;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplyButton.Location = new System.Drawing.Point(276, 214);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(82, 62);
            this.multiplyButton.TabIndex = 15;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // devideButton
            // 
            this.devideButton.AccessibleName = "calcBtns";
            this.devideButton.BackColor = System.Drawing.Color.DarkOrange;
            this.devideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devideButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.devideButton.Location = new System.Drawing.Point(276, 146);
            this.devideButton.Name = "devideButton";
            this.devideButton.Size = new System.Drawing.Size(82, 62);
            this.devideButton.TabIndex = 16;
            this.devideButton.Text = "/";
            this.devideButton.UseVisualStyleBackColor = false;
            this.devideButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // percentButton
            // 
            this.percentButton.BackColor = System.Drawing.SystemColors.Info;
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentButton.Location = new System.Drawing.Point(12, 78);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(82, 62);
            this.percentButton.TabIndex = 17;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.PercentButtonClicked);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Info;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(100, 78);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 62);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClicked);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.SystemColors.Info;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Location = new System.Drawing.Point(188, 78);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(82, 62);
            this.delButton.TabIndex = 19;
            this.delButton.Text = "Del";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.DelButtonClicked);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.DarkOrange;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equalButton.Location = new System.Drawing.Point(276, 78);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(82, 62);
            this.equalButton.TabIndex = 20;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButtonClicked);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(404, 445);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.devideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonValue);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.displayText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonValue;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button devideButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button equalButton;
    }
}

