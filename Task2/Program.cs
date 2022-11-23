//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Уявіть, що ви реалізуєте програму для банку, яка допомагає визначити, чи погасив клієнт кредит чи ні. 
//    Припустимо, щомісячна сума платежу має становити 100 грн. Клієнт повинен виконати 7 платежів, 
//    але може платити рідше за великі суми. Тобто може двома платежами по 300 і 400 грн. закрити весь обов'язок. 
//    Створіть метод, який як аргумент прийматиме суму платежу, введену економістом банку. 
//    Метод виводить на екран інформацію про стан кредиту 
//    (сума заборгованості, сума переплати, повідомлення про відсутність боргу). 

namespace Task2
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            decimal totalDeposit = 700, monthDeposit = 100;
            Recursion(totalDeposit, monthDeposit);
        }

        static void Recursion(decimal totalDeposit, decimal monthDeposit)
        {
            Console.Write("Enter the amount the customer deposited -> ");
            decimal clientDeposit = Convert.ToDecimal(Console.ReadLine());           
            
            if(clientDeposit < monthDeposit)
            {
                Console.WriteLine("Error! Deposit cannot be less than " + monthDeposit);
                return;
            }

            totalDeposit -= clientDeposit;
            Console.WriteLine("Balance: " + totalDeposit + "\nMonthly deposit:" + monthDeposit + "\nClient deposited: " + clientDeposit);

            if (totalDeposit == 0)
            {
                Console.WriteLine("Success! The loan closed");
                return;
            }
            else
                if(totalDeposit < 0)
                {
                    Console.WriteLine("Success! The loan closed. Please, return change " + (totalDeposit*-1) + " to client ");
                    return;
                }
                else
                Recursion(totalDeposit, monthDeposit);
        }
    }
}