using System;
using UserAccountBusinessServices;

namespace UserAccountUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();


            AccountService accountservice = new AccountService();
            bool result = accountservice.VerifyUser(username, password);

            if (result) 
            {
                Console.WriteLine("LOGIN SUCCESSFUL");
            }
            else
            {
                Console.WriteLine("LOGIN FAILED");
            }
        }
    }
}
