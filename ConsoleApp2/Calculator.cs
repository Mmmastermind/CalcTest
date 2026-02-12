using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Sub(double a, double b) => b - a;
        public double Mul(double a, double b) => a * b;
        public double Div(double a, double b) => a / b;
        public double Pow(double a, double b) => Math.Pow(a, b);
        public double Sqrt(double a) => Math.Sqrt(a);
        public double Percent(double a, double b) => a * b / 100.0;
        public double Log(double a) => Math.Log(a);
        public double Sin(double a) => Math.Sin(a);
        public double Ctg(double a) => Math.Cos(a) / Math.Sin(a);
    }

}
