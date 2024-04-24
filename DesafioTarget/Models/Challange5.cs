using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Models
{
    public class Challange5
    {
        public string InvertString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] characters = input.ToCharArray();
            int length = input.Length;

            for (int i = 0; i < length / 2; i++)
            {
                char temp = characters[i];
                characters[i] = characters[length - 1 - i];
                characters[length - 1 - i] = temp;
            }

            return new string(characters);
        }
    }
}