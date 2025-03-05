using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Calculator
    {
        int num1, num2, addition, subtraction, multiplication, division;
        public Calculator(int a, int b)
        {
            num1 = a;
            num2 = b;
        }
        //public int getNum1() { return num1; }
        //public int getNum2() { return num2; }
        public void Add()
        {
            addition = num1 + num2;
            Console.WriteLine("Addition of two numbers is: " + addition);
        }
        public void Sub()
        {
            subtraction = num1 - num2;
            Console.WriteLine("Subtraction of two numbers is: " + subtraction);
        }
        public void Mul()
        {
            multiplication = num1 * num2;
            Console.WriteLine("Multiplication of two numbers is: " + multiplication);
        }
        public void Div()
        {
            division = num1 / num2;
            Console.WriteLine("Division of two numbers is: " + division);
        }
    }
}
