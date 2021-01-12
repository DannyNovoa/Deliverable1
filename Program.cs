using System;
using System.Linq;

namespace PasswordDev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi Welcome! \nTo generate your password please enter your name: ");

            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Hola {userName} Let's generate a pasword  that contains the the following requirements:\n" +
               "1. At least one lowercase letter \n" +
               "2. At least one uppercase letter \n" +
               "3. A Minimum of 7 characters  \n"    +
               "4. A Maximum of 12 characters \n"   +
               "5. An exclamation pouint: !   \n" );

            string userPassword = Console.ReadLine();

            if (userPassword.Any(char.IsUpper) && userPassword.Any(char.IsLower) 
                && userPassword.Length >= 7 && userPassword.Contains("!"))
            {
                Console.WriteLine("Password is valid and accepted ");
            }
            else
            {
                Console.WriteLine("Sorry this is: No Bueno ");
            }

            Console.ReadKey();
        }
    }
}
