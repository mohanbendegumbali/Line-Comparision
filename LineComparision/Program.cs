using System; 

namespace LineComparision 
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine(" Welcome to Line Comparision problem statement");
            CalculateLength calculate = new CalculateLength(1, 2, 3, 4);
            calculate.Calculate();
        }
    }
}