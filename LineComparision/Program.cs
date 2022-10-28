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
            if (length1.Equals(length2))
                Console.WriteLine(" Both are equal");
            else
                Console.WriteLine(" Both are not equal");
                    
        }
    }
}