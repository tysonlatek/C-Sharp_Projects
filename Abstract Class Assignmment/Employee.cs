﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", Firstname, LastName);
        }
    }
}