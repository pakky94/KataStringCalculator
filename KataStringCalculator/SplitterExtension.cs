using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataStringCalculator
{
    public static class SplitterExtension
    {
        public static IEnumerable<int> Splitter(this string input) => input
            .Split(new string[] { ",", "\n" }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);
    }
}
