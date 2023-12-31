﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    internal class MathHelper
    {
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("You must specify a positive numeric value");
            }

            if (n <= 1)
            { 
                return 1;
            }

            int prevFactorial = Factorial(n - 1);
            return n * prevFactorial;
        }
    }
}
