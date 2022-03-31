using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class Pattern
    {
        public string FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public string LastName = "^[A-Z]{1}[a-z]{2,}$";
        public string Email = " ^[A - Z0 - 9a - z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public void validateFirstName(string firstName)
        {
            bool correct = Regex.IsMatch(firstName, FirstName);
            if (correct)
                Console.WriteLine("FirstName is correct");
            else
                Console.WriteLine("FirstName is not correct");
        }
        public void validateLastName(string lastName)
        {
            bool correct = Regex.IsMatch(lastName, LastName);
            if (correct)
                Console.WriteLine("LastName is correct");
            else
                Console.WriteLine("LastName is not correct");
        }
        public void validateEmail(string email)
        {
            bool correct = Regex.IsMatch(email, Email);
            if (correct)
                Console.WriteLine("Email is correct");
            else
                Console.WriteLine("Email is invilid");
        }
       
    }
}