using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene num");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine num");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vali tehe ('+','-','*' või '/')");
            char userOperation = Convert.ToChar(Console.ReadLine());

            switch(userOperation)
            {
                case '+':
                    AddTwoNumber(firstnumber, secondnumber);
                    break;
                case '/':
                    DivideTwoNumber(firstnumber, secondnumber);
                    break;
                case '*':
                    MultiplytwoNumber(firstnumber, secondnumber);
                    break;
                case '-':
                    SubtractTwoNumber(firstnumber, secondnumber);
                    break;
                default:
                    Console.WriteLine("vale tehe");
                    break;
            }

        }
        private static void AddTwoNumber(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void DivideTwoNumber(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");

        }

        private static void MultiplytwoNumber(double x, double y)

        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }
        
        private static void SubtractTwoNumber(int x, int y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }
    }
}
