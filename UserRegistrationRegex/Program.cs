using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.Write("Enter the FirstName : ");
            string firstName = Console.ReadLine();
            
            Console.Write("Enter the LastName : ");
            string lastName = Console.ReadLine();
            
            Console.Write("Enter the Email : ");
            string email = Console.ReadLine();
            pattern.validateFirstName(firstName);
            pattern.validateLastName(lastName);
            pattern.validateEmail(email);
        }
    }
}