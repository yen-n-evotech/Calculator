namespace Calculator2
{
    partial class Form1
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDevide = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayText
            // 
            this.displayText.Location = new System.Drawing.Point(13, 50);
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(338, 22);
            this.displayText.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(13, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 68);
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
            this.button8.Location = new System.Drawing.Point(100, 150);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 68);
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
            this.button9.Location = new System.Drawing.Point(184, 150);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 68);
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
            this.button4.Location = new System.Drawing.Point(13, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 68);
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
            this.button5.Location = new System.Drawing.Point(100, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 68);
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
            this.button6.Location = new System.Drawing.Point(184, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 68);
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
            this.button1.Location = new System.Drawing.Point(13, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 68);
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
            this.button2.Location = new System.Drawing.Point(100, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 68);
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
            this.button3.Location = new System.Drawing.Point(184, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 68);
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
            this.buttonValue.Location = new System.Drawing.Point(13, 363);
            this.buttonValue.Name = "buttonValue";
            this.buttonValue.Size = new System.Drawing.Size(81, 68);
            this.buttonValue.TabIndex = 10;
            this.buttonValue.Text = "+/-";
            this.buttonValue.UseVisualStyleBackColor = false;
            this.buttonValue.Click += new System.EventHandler(this.SignBtnClicked);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button0.Location = new System.Drawing.Point(100, 363);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(81, 68);
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
            this.buttonPoint.Location = new System.Drawing.Point(184, 363);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(81, 68);
            this.buttonPoint.TabIndex = 12;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleName = "CalcBtn";
            this.buttonAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(271, 366);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 65);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.CalcBtnClicked);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.AccessibleName = "CalcBtn";
            this.buttonSubtract.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubtract.Location = new System.Drawing.Point(271, 295);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(79, 65);
            this.buttonSubtract.TabIndex = 14;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.CalcBtnClicked);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.AccessibleName = "CalcBtn";
            this.buttonMultiply.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMultiply.Location = new System.Drawing.Point(271, 224);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(79, 65);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.CalcBtnClicked);
            // 
            // buttonDevide
            // 
            this.buttonDevide.AccessibleName = "CalcBtn";
            this.buttonDevide.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDevide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDevide.Location = new System.Drawing.Point(271, 150);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(79, 65);
            this.buttonDevide.TabIndex = 16;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = false;
            this.buttonDevide.Click += new System.EventHandler(this.CalcBtnClicked);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.SystemColors.Info;
            this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPercent.Location = new System.Drawing.Point(12, 78);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(82, 62);
            this.buttonPercent.TabIndex = 17;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Info;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(99, 78);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(82, 62);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(183, 78);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 63);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Del";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCount.Location = new System.Drawing.Point(271, 79);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(79, 65);
            this.buttonCount.TabIndex = 20;
            this.buttonCount.Text = "=";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.equalBtnClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(368, 445);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonDevide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDevide;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCount;
    }
}

