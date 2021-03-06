using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_OOP
{
    class single_op
    {
        private double num;
        private string single_operation;
        private double result;

        //methods
        public double operation()
        {
            if (single_operation == "-")
            {
                num *= -1;
                result = num;
            }
            if (single_operation == "/")
            {
                result = Math.Round(1 / num, 6);
            }
            if (single_operation == "x*x")
            {
                result = Math.Round(num * num, 6);
            }
            if (single_operation == "√x")
            {
                result = Math.Round(Math.Sqrt(num), 6);
            }
            if (single_operation == "%")
            {
                result = num / 100;
            }
            return result;
        }

        
        //constructor
        public single_op(double num, string single_operation)
        {
            this.num = num;
            this.single_operation = single_operation;
        }

        //getters
        public double getnum()
        {
            return num;
        }
        public string getsingle_op()
        {
            return single_operation;
        }
        private double getresult()
        {
            return result;
        }
        //setters
        public void setnum(double num)
        {
            this.num = num;
        }
        public void setsingleop(string single_operation)
        {
            this.single_operation = single_operation;
        }
        public void setresult(double result)
        {
            this.result = result;
        }


    }
}
