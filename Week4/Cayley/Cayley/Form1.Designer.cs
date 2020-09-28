using System.Windows.Forms;

namespace Cayley
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
            this.Start = new System.Windows.Forms.Button();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.LengthLable = new System.Windows.Forms.Label();
            this.RightPerLabel = new System.Windows.Forms.Label();
            this.LeftPerLabel = new System.Windows.Forms.Label();
            this.RightAngelLabel = new System.Windows.Forms.Label();
            this.LeftAngelTable = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.RightAngel = new System.Windows.Forms.TextBox();
            this.LeftAngle = new System.Windows.Forms.TextBox();
            this.RightLengthPer = new System.Windows.Forms.HScrollBar();
            this.LeftLengthPer = new System.Windows.Forms.HScrollBar();
            this.DeepCombo = new System.Windows.Forms.ComboBox();
            this.MainLength = new System.Windows.Forms.TextBox();
            this.RightPerNum = new System.Windows.Forms.Label();
            this.LeftPerNum = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1086, 39);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(139, 63);
            this.Start.TabIndex = 0;
            this.Start.Text = "生成(&r)";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(12, 39);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(80, 18);
            this.DepthLabel.TabIndex = 1;
            this.DepthLabel.Text = "递归深度";
            // 
            // LengthLable
            // 
            this.LengthLable.AutoSize = true;
            this.LengthLable.Location = new System.Drawing.Point(12, 99);
            this.LengthLable.Name = "LengthLable";
            this.LengthLable.Size = new System.Drawing.Size(80, 18);
            this.LengthLable.TabIndex = 2;
            this.LengthLable.Text = "主干长度";
            // 
            // RightPerLabel
            // 
            this.RightPerLabel.AutoSize = true;
            this.RightPerLabel.Location = new System.Drawing.Point(266, 39);
            this.RightPerLabel.Name = "RightPerLabel";
            this.RightPerLabel.Size = new System.Drawing.Size(116, 18);
            this.RightPerLabel.TabIndex = 3;
            this.RightPerLabel.Text = "右分支长度比";
            // 
            // LeftPerLabel
            // 
            this.LeftPerLabel.AutoSize = true;
            this.LeftPerLabel.Location = new System.Drawing.Point(266, 99);
            this.LeftPerLabel.Name = "LeftPerLabel";
            this.LeftPerLabel.Size = new System.Drawing.Size(116, 18);
            this.LeftPerLabel.TabIndex = 4;
            this.LeftPerLabel.Text = "左分支长度比";
            // 
            // RightAngelLabel
            // 
            this.RightAngelLabel.AutoSize = true;
            this.RightAngelLabel.Location = new System.Drawing.Point(551, 39);
            this.RightAngelLabel.Name = "RightAngelLabel";
            this.RightAngelLabel.Size = new System.Drawing.Size(98, 18);
            this.RightAngelLabel.TabIndex = 5;
            this.RightAngelLabel.Text = "右分支角度";
            // 
            // LeftAngelTable
            // 
            this.LeftAngelTable.AutoSize = true;
            this.LeftAngelTable.Location = new System.Drawing.Point(551, 99);
            this.LeftAngelTable.Name = "LeftAngelTable";
            this.LeftAngelTable.Size = new System.Drawing.Size(98, 18);
            this.LeftAngelTable.TabIndex = 6;
            this.LeftAngelTable.Text = "左分支角度";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(876, 74);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(80, 18);
            this.ColorLabel.TabIndex = 8;
            this.ColorLabel.Text = "画笔颜色";
            this.ColorLabel.Click += new System.EventHandler(this.ColorLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1281, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "结果：";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(1339, 64);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(80, 18);
            this.Result.TabIndex = 10;
            this.Result.Text = "Not yet.";
            // 
            // RightAngel
            // 
            this.RightAngel.Location = new System.Drawing.Point(664, 36);
            this.RightAngel.Name = "RightAngel";
            this.RightAngel.Size = new System.Drawing.Size(100, 28);
            this.RightAngel.TabIndex = 11;
            this.RightAngel.Text = "60";
            // 
            // LeftAngle
            // 
            this.LeftAngle.Location = new System.Drawing.Point(664, 96);
            this.LeftAngle.Name = "LeftAngle";
            this.LeftAngle.Size = new System.Drawing.Size(100, 28);
            this.LeftAngle.TabIndex = 12;
            this.LeftAngle.Text = "30";
            // 
            // RightLengthPer
            // 
            this.RightLengthPer.Location = new System.Drawing.Point(389, 36);
            this.RightLengthPer.Maximum = 200;
            this.RightLengthPer.Minimum = 1;
            this.RightLengthPer.Name = "RightLengthPer";
            this.RightLengthPer.Size = new System.Drawing.Size(159, 26);
            this.RightLengthPer.TabIndex = 13;
            this.RightLengthPer.Value = 1;
            this.RightLengthPer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RightLengthPer_Scroll);
            this.RightLengthPer.ValueChanged += new System.EventHandler(this.RightLengthPer_ValueChanged);
            // 
            // LeftLengthPer
            // 
            this.LeftLengthPer.Location = new System.Drawing.Point(389, 96);
            this.LeftLengthPer.Maximum = 200;
            this.LeftLengthPer.Minimum = 1;
            this.LeftLengthPer.Name = "LeftLengthPer";
            this.LeftLengthPer.Size = new System.Drawing.Size(159, 26);
            this.LeftLengthPer.TabIndex = 14;
            this.LeftLengthPer.Value = 1;
            this.LeftLengthPer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LeftLengthPer_Scroll);
            this.LeftLengthPer.ValueChanged += new System.EventHandler(this.LeftLengthPer_ValueChanged);
            // 
            // DeepCombo
            // 
            this.DeepCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeepCombo.FormattingEnabled = true;
            this.DeepCombo.Location = new System.Drawing.Point(106, 36);
            this.DeepCombo.Name = "DeepCombo";
            this.DeepCombo.Size = new System.Drawing.Size(133, 26);
            this.DeepCombo.TabIndex = 16;
            this.DeepCombo.SelectedValueChanged += new System.EventHandler(this.DeepCombo_SelectedValueChanged);
            // 
            // MainLength
            // 
            this.MainLength.Location = new System.Drawing.Point(106, 96);
            this.MainLength.Name = "MainLength";
            this.MainLength.Size = new System.Drawing.Size(133, 28);
            this.MainLength.TabIndex = 17;
            this.MainLength.Text = "100";
            // 
            // RightPerNum
            // 
            this.RightPerNum.AutoSize = true;
            this.RightPerNum.Location = new System.Drawing.Point(448, 74);
            this.RightPerNum.Name = "RightPerNum";
            this.RightPerNum.Size = new System.Drawing.Size(0, 18);
            this.RightPerNum.TabIndex = 18;
            // 
            // LeftPerNum
            // 
            this.LeftPerNum.AutoSize = true;
            this.LeftPerNum.Location = new System.Drawing.Point(448, 135);
            this.LeftPerNum.Name = "LeftPerNum";
            this.LeftPerNum.Size = new System.Drawing.Size(0, 18);
            this.LeftPerNum.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.LeftPerNum);
            this.Controls.Add(this.RightPerNum);
            this.Controls.Add(this.MainLength);
            this.Controls.Add(this.DeepCombo);
            this.Controls.Add(this.LeftLengthPer);
            this.Controls.Add(this.RightLengthPer);
            this.Controls.Add(this.LeftAngle);
            this.Controls.Add(this.RightAngel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.LeftAngelTable);
            this.Controls.Add(this.RightAngelLabel);
            this.Controls.Add(this.LeftPerLabel);
            this.Controls.Add(this.RightPerLabel);
            this.Controls.Add(this.LengthLable);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Cayley";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label LengthLable;
        private System.Windows.Forms.Label RightPerLabel;
        private System.Windows.Forms.Label LeftPerLabel;
        private System.Windows.Forms.Label RightAngelLabel;
        private System.Windows.Forms.Label LeftAngelTable;
        private System.Windows.Forms.Label ColorLabel;
        private Label label8;
        private Label Result;
        private TextBox RightAngel;
        private TextBox LeftAngle;
        private HScrollBar RightLengthPer;
        private HScrollBar LeftLengthPer;
        private ComboBox DeepCombo;
        private TextBox MainLength;
        private Label RightPerNum;
        private Label LeftPerNum;
        private ColorDialog colorDialog1;
    }
}

