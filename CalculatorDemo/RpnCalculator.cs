using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDemo
{
    public class RpnCalculator
    {
        private Stack<double> _stack = new Stack<double>();

        public void EnterNumber(double n)
        {
            _stack.Push(n);
        }

        public double Add()
        {
            var result = _stack.Pop() + _stack.Pop();
            _stack.Push(result);
            return result;
        }

        public double CurrentValue()
        {
            return _stack.Peek();
        }
    }
}
