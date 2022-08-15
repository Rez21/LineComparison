using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1_Line_Length length = new UC1_Line_Length();
            length.CallLength(5, 6, 7, 8);

            UC2_Line_Length_Comparison.CompareLine();
        }
    }
}