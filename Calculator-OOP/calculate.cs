using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_OOP
{
    class calculate
    {
        //attributes
        private double num1;
        private double num2;
        private string op;
        private double result;

        public double calculation()
        {
            if (op == "+")
            {
                result = num1 + num2;
            }
            if (op == "-")
            {
                result = num1 - num2;
            }
            if (op == "*")
            {
                result = num1 * num2;
            }
            if (op == "/")
            {
                result = num1 / num2;
            }
            return result;
        }

        //constructors
        public calculate(double num1, double num2, string op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
        }

        //getters
        public double getnum1()
        {
            return num1;
        }
        public double getnum2()
        {
            return num2;
        }
        public string getop()
        {
            return op;
        }
        public double getresult()
        {
            return result;
        }

        //settters
        public void setnum1(double num1)
        {
            this.num1 = num1;
        }
        public void setnum2(double num2)
        {
            this.num2 = num2;
        }
        public void setop(string op)
        {
            this.op = op;
        }
        public void setresult(double result)
        {
            this.result = result;
        }
    }

}
