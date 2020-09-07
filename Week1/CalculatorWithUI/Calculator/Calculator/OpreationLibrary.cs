using System;
using System.Collections.Generic;
using System.Text;

namespace OperationLibrary
{
    /// <summary>
    /// 运算类
    /// </summary>
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get
            {
                return _numberA;
            }
            set
            {
                _numberA = value;
            }
        }

        public double NumberB
        {
            get
            {
                return _numberB;
            }
            set
            {
                _numberB = value;
            }
        }

        /// 得到运算结果
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

    }

    /// 加法类
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    /// 减法类
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    /// 乘法类
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    /// 除法类
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            return NumberA / NumberB;
        }
    }

    /// 运算类工厂
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    {
                        oper = new OperationAdd();
                        break;
                    }
                case "-":
                    {
                        oper = new OperationSub();
                        break;
                    }
                case "*":
                    {
                        oper = new OperationMul();
                        break;
                    }
                case "/":
                    {
                        oper = new OperationDiv();
                        break;
                    }
                default:
                    {
                        throw new Exception("操作数错误\n");
                    }
            }

            return oper;
        }
    }

}
