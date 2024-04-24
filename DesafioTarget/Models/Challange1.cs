using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Models
{
    public class Challange1
    {
        public void Sum()
        {
            int index = 13;
            int sum = 0;
            int k = 0;

            while (k < index)
            {
                k++;
                sum += k;
            }

            Console.WriteLine("Valor da soma: " + sum);
        }
    }
}