using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public bool IsDivisibleByThree(int i)
        {
            return (i % 3) == 0;
        }

        public bool IsDivisibleByFive(int i)
        {
            return (i % 5) == 0;
        }

        public bool IsNotDivisibleByFive(int i)
        {
            return (i%5) != 0;
        }

        public bool IsNotDivisibleByThree(int i)
        {
            return (i%3) != 0;
        }

        public bool IsDivisibleByThreeAndFive(int i)
        {
            return (i%3) == 0 && (i%5) == 0;
        }

        public string GetTextForNumber(int i)
        {
            if (IsDivisibleByThreeAndFive(i))
            {
                return "FizzBuzz";
            }
            if (IsDivisibleByFive(i))
            {
                return "Buzz";
            }
            if (IsDivisibleByThree(i))
            {
                return "Fizz";
            }
            else
            {
                return i.ToString();
            }
        }

        public string TheWholeThing(int range)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= range; ++i)
            {
                sb.AppendFormat("{0} ", GetTextForNumber(i));
            }
            return sb.ToString();
        }
    }
}
