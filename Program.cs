using System;

namespace homeWorkPasswordProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "123456";
            int passwordTryCount = 2;
            string userPasswordInput;

            for (int i = 0; i <= passwordTryCount; i++)
            {
                Console.Write("Please enter password: ");
                userPasswordInput = Console.ReadLine();

                if (userPasswordInput == password)
                {
                    Console.WriteLine("secret massege");
                    break;
                }
                else if (i == passwordTryCount)
                {
                    Console.WriteLine("attempts are over");
                }
                else
                {
                    Console.WriteLine("Wrong password, please try again");
                }
            }
        }
    }
}
