//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Створіть метод з ім'ям Calculate, 
//    який приймає як параметри три цілих значення і повертає значення кожного аргументу поділеного на 5.

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 -> ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2 -> ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num3 -> ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            double res1, res2, res3;
            Calculate(num1, num2, num3,out res1,out res2, out res3);
            Console.WriteLine("res1 = " + res1 + " res2 = " + res2 + " res3 = " + res3);
        }

        static void Calculate(int num1, int num2, int num3, out double res1, out double res2, out double res3)
        {
            res1 = num1/ 5;
            res2 = num2/ 5;
            res3 = num3/ 5;
        }
    }
}