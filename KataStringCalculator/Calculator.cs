using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataStringCalculator
{
    public class Calculator : ICalculator
    {
        public int Add(string input)
        {
            if (input.Equals(string.Empty))
                return 0;

            var splitting = input.Split(",");
            return splitting.Sum(x => int.Parse(x));
        }
    }
}
