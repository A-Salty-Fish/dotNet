using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperationLibrary;

namespace Calculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            const int MAXINPUTNUM = 16;
            TextNum1.MaxLength = MAXINPUTNUM;
            TextNum2.MaxLength = MAXINPUTNUM;
            TextResult.ReadOnly = true;

            OperatorBox.Items.Add("+");
            OperatorBox.Items.Add("-");
            OperatorBox.Items.Add("*");
            OperatorBox.Items.Add("/");

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                string strNumberA = TextNum1.Text;

                string strOperate = OperatorBox.Text;
                Operation oper;
                oper = OperationFactory.createOperate(strOperate);

                string strNumberB = TextNum2.Text;
                string strResult = "";

                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);
                strResult = oper.GetResult().ToString();

                TextResult.Text = strResult;
            }
            catch (Exception ex)
            {
                TextResult.Text= ex.Message;
            }
        }
    }
}
