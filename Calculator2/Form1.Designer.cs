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
            this.pointButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.signButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayText
            // 
            this.displayText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayText.BackColor = System.Drawing.Color.Black;
            this.displayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayText.Font = new System.Drawing.Font("Franklin Gothic Medium", 28.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayText.ForeColor = System.Drawing.SystemColors.Window;
            this.displayText.Location = new System.Drawing.Point(3, 61);
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayText.Size = new System.Drawing.Size(720, 55);
            this.displayText.TabIndex = 0;
            this.displayText.Text = "0";
            this.displayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayText.TextChanged += new System.EventHandler(this.DisplayTextChanged);
            this.displayText.Enter += new System.EventHandler(this.DisplayTextEnter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(3, 118);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 109);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(183, 118);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 109);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(363, 118);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(174, 109);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(3, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 109);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(183, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 109);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(363, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 109);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(3, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 109);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(183, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 109);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(363, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 109);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.Color.Gray;
            this.pointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pointButton.Location = new System.Drawing.Point(363, 463);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(174, 110);
            this.pointButton.TabIndex = 19;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = false;
            this.pointButton.Click += new System.EventHandler(this.PointButtonClicked);
            // 
            // addButton
            // 
            this.addButton.AccessibleName = "CalcBtns";
            this.addButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(543, 348);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(174, 109);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // subtractButton
            // 
            this.subtractButton.AccessibleName = "CalcBtns";
            this.subtractButton.BackColor = System.Drawing.Color.DarkOrange;
            this.subtractButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtractButton.Location = new System.Drawing.Point(543, 463);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(174, 110);
            this.subtractButton.TabIndex = 20;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // multiplyButton
            // 
            this.multiplyButton.AccessibleName = "CalcBtns";
            this.multiplyButton.BackColor = System.Drawing.Color.DarkOrange;
            this.multiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplyButton.Location = new System.Drawing.Point(543, 233);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(174, 109);
            this.multiplyButton.TabIndex = 12;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // devideButton
            // 
            this.devideButton.AccessibleName = "CalcBtns";
            this.devideButton.BackColor = System.Drawing.Color.DarkOrange;
            this.devideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devideButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.devideButton.Location = new System.Drawing.Point(543, 118);
            this.devideButton.Name = "devideButton";
            this.devideButton.Size = new System.Drawing.Size(174, 109);
            this.devideButton.TabIndex = 8;
            this.devideButton.Text = "/";
            this.devideButton.UseVisualStyleBackColor = false;
            this.devideButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // percentButton
            // 
            this.percentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.percentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.percentButton.Location = new System.Drawing.Point(3, 3);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(174, 109);
            this.percentButton.TabIndex = 1;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.PercentButtonClicked);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(183, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(174, 109);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClicked);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.ForeColor = System.Drawing.SystemColors.Control;
            this.delButton.Location = new System.Drawing.Point(363, 3);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(174, 109);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Del";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.DelButtonClicked);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.DarkOrange;
            this.equalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equalButton.Location = new System.Drawing.Point(543, 3);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(174, 109);
            this.equalButton.TabIndex = 4;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButtonClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.displayText, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 701);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.percentButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.subtractButton, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.signButton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.multiplyButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.devideButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.equalButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.clearButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.delButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.addButton, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.pointButton, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button0, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 122);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(720, 576);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // signButton
            // 
            this.signButton.BackColor = System.Drawing.Color.Gray;
            this.signButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signButton.Location = new System.Drawing.Point(3, 463);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(174, 110);
            this.signButton.TabIndex = 17;
            this.signButton.Text = "+/-";
            this.signButton.UseVisualStyleBackColor = false;
            this.signButton.Click += new System.EventHandler(this.SignButtonClicked);
            // 
            // button0
            // 
            this.button0.AutoSize = true;
            this.button0.BackColor = System.Drawing.Color.Gray;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button0.Location = new System.Drawing.Point(183, 463);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(174, 110);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(728, 706);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(697, 704);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button devideButton;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button button0;
    }
}

