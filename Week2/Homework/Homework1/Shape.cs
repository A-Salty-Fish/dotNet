using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Homework1
{
    interface Shape
    {

        /// <summary>
        /// 判断形状是否合法
        /// </summary>
        public bool IsLegal();
        /// <summary>
        /// 返回面积
        /// </summary>
        public double GetArea();
        /// <summary>
        /// 打印所有点
        /// </summary>
        public void ShowPoints();
    }
}
