using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input="")
        {
            if(string.IsNullOrEmpty(input))
                return 0; 

            string[] numbers = input.Split(',');

            if (numbers.Length == 1)
            {
                return Int32.Parse(numbers[0]);
            }
            
            int sum = Int32.Parse(numbers[0]) + Int32.Parse(numbers[1]);

            return sum;
        }
    }
}