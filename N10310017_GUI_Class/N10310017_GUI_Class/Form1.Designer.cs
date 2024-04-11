namespace N10310017_GUI_Class
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label班級 = new System.Windows.Forms.Label();
            this.label姓名 = new System.Windows.Forms.Label();
            this.label學號 = new System.Windows.Forms.Label();
            this.bntButton = new System.Windows.Forms.Button();
            this.bntBMI = new System.Windows.Forms.Button();
            this.button按鈕 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label班級
            // 
            this.label班級.AutoSize = true;
            this.label班級.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label班級.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label班級.Location = new System.Drawing.Point(12, 9);
            this.label班級.Name = "label班級";
            this.label班級.Size = new System.Drawing.Size(220, 37);
            this.label班級.TabIndex = 0;
            this.label班級.Text = "多遊系三年甲班";
            this.label班級.Click += new System.EventHandler(this.label1_Click);
            // 
            // label姓名
            // 
            this.label姓名.AutoSize = true;
            this.label姓名.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label姓名.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label姓名.Location = new System.Drawing.Point(684, 9);
            this.label姓名.Name = "label姓名";
            this.label姓名.Size = new System.Drawing.Size(104, 37);
            this.label姓名.TabIndex = 1;
            this.label姓名.Text = "謝明凱";
            // 
            // label學號
            // 
            this.label學號.AutoSize = true;
            this.label學號.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label學號.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label學號.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label學號.Location = new System.Drawing.Point(339, 9);
            this.label學號.Name = "label學號";
            this.label學號.Size = new System.Drawing.Size(177, 37);
            this.label學號.TabIndex = 2;
            this.label學號.Text = "N10310017";
            this.label學號.Click += new System.EventHandler(this.label3_Click);
            // 
            // bntButton
            // 
            this.bntButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bntButton.Location = new System.Drawing.Point(19, 132);
            this.bntButton.Name = "bntButton";
            this.bntButton.Size = new System.Drawing.Size(158, 70);
            this.bntButton.TabIndex = 3;
            this.bntButton.Text = "按鈕";
            this.bntButton.UseVisualStyleBackColor = false;
            // 
            // bntBMI
            // 
            this.bntBMI.Location = new System.Drawing.Point(19, 208);
            this.bntBMI.Name = "bntBMI";
            this.bntBMI.Size = new System.Drawing.Size(158, 46);
            this.bntBMI.TabIndex = 4;
            this.bntBMI.Text = "BMI計算";
            this.bntBMI.UseVisualStyleBackColor = true;
            // 
            // button按鈕
            // 
            this.button按鈕.Location = new System.Drawing.Point(390, 230);
            this.button按鈕.Name = "button按鈕";
            this.button按鈕.Size = new System.Drawing.Size(235, 120);
            this.button按鈕.TabIndex = 5;
            this.button按鈕.Text = "請按我一下";
            this.button按鈕.UseVisualStyleBackColor = true;
            this.button按鈕.Click += new System.EventHandler(this.button按我一下_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "輸入框";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button按鈕);
            this.Controls.Add(this.bntBMI);
            this.Controls.Add(this.bntButton);
            this.Controls.Add(this.label學號);
            this.Controls.Add(this.label姓名);
            this.Controls.Add(this.label班級);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label班級;
        private System.Windows.Forms.Label label姓名;
        private System.Windows.Forms.Label label學號;
        private System.Windows.Forms.Button bntButton;
        private System.Windows.Forms.Button bntBMI;
        private System.Windows.Forms.Button button按鈕;
        private System.Windows.Forms.Button button4;
    }
}

