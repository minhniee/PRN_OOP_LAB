﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_OOP_EX2
{
    internal class Customer : Person
    {
        public int Balance { get; set; }
        public Customer(string name, string address, int balance) : base(name, address)
        {
            Balance = balance;
        }

        public override void Display()
        {
            Console.WriteLine($"Customer: Name:{Name}, Balance: {Balance}");
        }
    }
}
