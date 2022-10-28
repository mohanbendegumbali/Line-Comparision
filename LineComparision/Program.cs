using System; 

namespace LineComparision 
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine(" Welcome to Line Comparision problem statement");
            CalculateLength calculate1 = new CalculateLength(1, 2, 3, 4);
            double length1 = calculate1.Calculate();
            CalculateLength calculate2 = new CalculateLength(1, 2, 3, 4);
            double length2 = calculate2.Calculate();
            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine(" Line1 and Line2 are equal ");
                return;
            }
            if (length1.CompareTo(length2)>0)
                Console.WriteLine(" Line1 is greater than Line2");
            else
                Console.WriteLine(" Line2 is greater than Line1");            
        }
    }
}