﻿using System;
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
        public string MobileNo = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
        public string Password = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9!@#$%^&*]{8,}$";
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
        public void validateMobileNo(string mobileNo)
        {
            bool correct = Regex.IsMatch(mobileNo, MobileNo);
            if (correct)
                Console.WriteLine("Mobile Number is correct");
            else
                Console.WriteLine("Mobile Number is not correct");
        }
        public void validateEmail(string email)
        {
            bool correct = Regex.IsMatch(email, Email);
            if (correct)
                Console.WriteLine("Email is correct");
            else
                Console.WriteLine("Email is not correct");
        }
        public void validatePassword(string password)
        {
            bool correct = Regex.IsMatch(password, Password);
            if (correct)
                Console.WriteLine("Password iscorrect");
            else
                Console.WriteLine("Password is not correct");
        }
    }
}
