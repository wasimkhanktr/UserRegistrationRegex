﻿using System;
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
            pattern.validate(firstName);
        }
    }
}