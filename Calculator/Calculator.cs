using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Addition(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Addition(int[] num1)
        {
            int resutat = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                resutat += Convert.ToInt32(num1[i].ToString());
            }

            return resutat;
        }

        public int Subtraction(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int Subtraction(int[] num1)
        {
            int resutat = 0;
            
            for (int i = 0; i < num1.Length; i++)
            {
                if(i == 0)
                {
                    resutat = num1[0];
                }else
                {
                    resutat -= Convert.ToInt32(num1[i].ToString());
                }
            }

            return resutat;
        }

        public int Division(int num1, int num2)
        {
            if(num2 == 0)
                throw new DivideByZeroException();
            
            return num1 / num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int SquareRoot(int num1)
        {
            return (int)Math.Sqrt(num1);
        }

        public int Max(int num1, int num2)
        {

            return Math.Max(num1, num2);
        }

        public int Min(int num1, int num2)
        {
            return Math.Min(num1, num2);
        }

        public int Absolute(int num)
        {
            return Math.Abs(num);
        }

        public int Log2(int num)
        {
            return (int)Math.Log2(num);
        }

        public int Log10(int num)
        {
            return (int)Math.Log10(num);
        }

        public int Percent(int num, int num2)//ok
        {
            double maths = Convert.ToDouble(num2);
            double temp = (maths / 100);
            return (int)Math.Round(num * temp);
        }
    }
}
