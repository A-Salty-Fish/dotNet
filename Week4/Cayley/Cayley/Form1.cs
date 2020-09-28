using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 3; i < 15; i++)
                this.DeepCombo.Items.Add(i.ToString());
            this.DeepCombo.SelectedIndex = 0;
        }

        int GetLength()//获取长度
        {
            int Length;
            if (!int.TryParse(this.MainLength.Text, out Length)) throw new Exception("Invalid Length.");
            else if (Length > 200) throw new Exception("Too Large Length");
            else return Length;
        }

        int GetDepth()
        {
            return int.Parse(this.DeepCombo.Text);
        }

        double GetLeftAngel()
        {
            double angel;
            if (!double.TryParse(this.LeftAngle.Text, out angel)) throw new Exception("Invalid Left Angel Input.");
            else return angel;
        }

        double GetRightAngel()
        {
            double angel;
            if (!double.TryParse(this.RightAngel.Text, out angel)) throw new Exception("Invalid Left Angel Input.");
            else return angel;
        }

        double GetLeftLengthPer()
        {
            return (double)this.LeftLengthPer.Value / this.LeftLengthPer.Maximum;
        }
        double GetRightLengthPer()
        {
            return (double)this.RightLengthPer.Value / this.RightLengthPer.Maximum;
        }

        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                this.Result.Text = "Generating...";
                DrawDynamic();
                this.Result.Text = "End";
            }
            catch (Exception exception)
            {
                this.Result.Text = exception.Message;
            }
        }

        void DrawDynamic()
        {
            //获取窗口大小
            int x = this.Width / 2;
            int y = this.Height * 8 / 9;
            //获取各个输入参数并检查合法性
            int Depth = GetDepth();
            int Length = GetLength();
            th1 = GetLeftAngel() * Math.PI / 180;
            th2 = GetRightAngel() * Math.PI / 180;
            per1 = GetLeftLengthPer();
            per2 = GetRightLengthPer();
            //绘图
            if (graphics == null) graphics = this.CreateGraphics();
            graphics.Clear(BackColor);

            DraCayleyTree(Depth, x, y, Length, -Math.PI / 2);
        }

        void DraCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0,y0,x1,y1);

            DraCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DraCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void DrawLine(double x0, double y0, double x1, double y1)
        {
            Pen p=new Pen(Color.Black);
            p.Color = colorDialog1.Color;
            graphics.DrawLine(p, (int)x0, (int)y0, (int)x1, (int)y1);

        }

        private void RightLengthPer_Scroll(object sender, ScrollEventArgs e)
        {
            this.RightPerNum.Text = ((double) this.RightLengthPer.Value / this.RightLengthPer.Maximum).ToString();
        }

        private void LeftLengthPer_Scroll(object sender, ScrollEventArgs e)
        {
            this.LeftPerNum.Text = ((double)this.LeftLengthPer.Value / this.LeftLengthPer.Maximum).ToString();
        }

        private void ColorLabel_Click(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog();
            ColorLabel.ForeColor = colorDialog1.Color;
        }

        private void DeepCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            DrawDynamic();
        }


        private void LeftLengthPer_ValueChanged(object sender, EventArgs e)
        {
            DrawDynamic();
        }

        private void RightLengthPer_ValueChanged(object sender, EventArgs e)
        {
            DrawDynamic();
        }
    }
}
