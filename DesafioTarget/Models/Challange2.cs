using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Models
{
    public class Challange2
    {
        public bool CheckFibonacciSequence(int number)
        {
            int first = 0;
            int second = 1;

            while (second <= number)
            {
                if (second == number)
                {
                    Console.WriteLine($"{number} pertence à sequência de Fibonacci.");
                    return true;
                }

                int next = first + second;
                first = second;
                second = next;
            }

            Console.WriteLine($"{number} não pertence à sequência de Fibonacci.");
            return false;
        }
    }
}