using ControlHub.BE;
using System;
using System.Reflection;

namespace ControlHub.BL
{
    public interface IFibonacciBL
    {
        FibonacciBE GetValueFibonacci(int index);
    }
    public class FibonacciBL : IFibonacciBL
    {
        public FibonacciBE GetValueFibonacci(int index)
        {
            try
            {
                var fibonacciBE = new FibonacciBE();
                if (index >= 0)
                {
                    fibonacciBE.index = index;
                    fibonacciBE.value = GetValue(index);
                    return fibonacciBE;
                }
                else
                {
                    throw new Exception("Value is invalid");
                }
            }
            catch (Exception e) { throw e; }
        }

        static int GetValue(int index)
        {
            if (index < 2)
            {
                return index;
            }
            return GetValue(index - 1) + GetValue(index - 2);
        }
    }
}