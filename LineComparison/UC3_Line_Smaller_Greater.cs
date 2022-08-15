using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC3_Line_Smaller_Greater
    {
        public static void Compare()
        {
            int x1, y1, x2, y2, x3, y3, x4, y4;                 
            double firstLength, secLength;
            Console.WriteLine("Enter X1 point");            
            x1 = Convert.ToInt32(Console.ReadLine());         
            Console.WriteLine("Enter y1 point");           
            y1 = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine("Enter X2 point");            
            x2 = Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine("Enter Y2 point");            
            y2 = Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine("Enter X3 point");            
            x3 = Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine("Enter y3 point");           
            y3 = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine("Enter X4 point");            
            x4 = Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine("Enter Y4 point");           
            y4 = Convert.ToInt32(Console.ReadLine());        

            firstLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));       
            Console.WriteLine("first Length is:" + Math.Round(firstLength, 2));         
            secLength = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));        
            Console.WriteLine("Second Length is :" + Math.Round(secLength, 2));        

            int diffLength = firstLength.CompareTo(secLength);                       
            Console.WriteLine("\nUsing CompareTo Method");
            if (diffLength == 0)                                                
                Console.WriteLine("Lines are equal");
            else if (diffLength > 0)
                Console.WriteLine("First Line Length is greater than Second line Length");
            else
                Console.WriteLine("first Line Length is less than Second line Length");
        }
    }
}
