using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC1_Line_Length
    {
     
        
            public void CallLength(double x1, double y1, double x2, double y2)       
            {
                double a = Math.Sqrt(Math.Pow(x2 - x1, 2));           
                double b = Math.Sqrt(Math.Pow(y2 - y1, 2));           
                double c = a + b;                                    
                Console.WriteLine("Length of a line is :" + c);      
            }
        
    }
}
