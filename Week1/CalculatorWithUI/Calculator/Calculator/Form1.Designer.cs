namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TextNum1 = new System.Windows.Forms.TextBox();
            this.TextNum2 = new System.Windows.Forms.TextBox();
            this.OperatorBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextNum1
            // 
            this.TextNum1.Font = new System.Drawing.Font("宋体", 20F);
            this.TextNum1.Location = new System.Drawing.Point(334, 69);
            this.TextNum1.Name = "TextNum1";
            this.TextNum1.Size = new System.Drawing.Size(350, 53);
            this.TextNum1.TabIndex = 0;
            // 
            // TextNum2
            // 
            this.TextNum2.Font = new System.Drawing.Font("宋体", 20F);
            this.TextNum2.Location = new System.Drawing.Point(334, 233);
            this.TextNum2.Name = "TextNum2";
            this.TextNum2.Size = new System.Drawing.Size(350, 53);
            this.TextNum2.TabIndex = 1;
            // 
            // OperatorBox
            // 
            this.OperatorBox.Font = new System.Drawing.Font("宋体", 20F);
            this.OperatorBox.FormattingEnabled = true;
            this.OperatorBox.Location = new System.Drawing.Point(334, 153);
            this.OperatorBox.Name = "OperatorBox";
            this.OperatorBox.Size = new System.Drawing.Size(157, 48);
            this.OperatorBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(191, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "数字1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(191, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "数字2";
            // 
            // TextResult
            // 
            this.TextResult.Font = new System.Drawing.Font("宋体", 20F);
            this.TextResult.Location = new System.Drawing.Point(334, 318);
            this.TextResult.Name = "TextResult";
            this.TextResult.Size = new System.Drawing.Size(532, 53);
            this.TextResult.TabIndex = 5;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("宋体", 20F);
            this.btnResult.Location = new System.Drawing.Point(198, 318);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(110, 53);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(182, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "运算符";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.TextResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorBox);
            this.Controls.Add(this.TextNum2);
            this.Controls.Add(this.TextNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextNum1;
        private System.Windows.Forms.TextBox TextNum2;
        private System.Windows.Forms.ComboBox OperatorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label3;
    }
}

