//Є N клієнтів, яким компанія-виробник має доставити товар. 
//    Скільки існує можливих маршрутів доставки товару з урахуванням того, що товар доставлятиме одна машина? 
//    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Напишіть програму, яка розраховуватиме і виводитиме на екран кількість можливих варіантів доставки товару. 
//    Для вирішення задачі, використовуйте факторіал N!, що розраховується за допомогою рекурсії. 
//    Поясніть, чому не рекомендується використовувати рекурсію для розрахунку факторіалу. 
//    Вкажіть слабкі місця цього підходу.

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of clients -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result = "+Factorial(n));
        }
        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}