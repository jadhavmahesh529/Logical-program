﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprogramming
{
    internal class Primenumber
    {
        public void GeneratePrimeNumber()
        {

            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }


        }


    }
}
