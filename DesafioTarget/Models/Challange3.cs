using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Models
{
    public class Challange3
    {
        public void PredictAndPrintNextNumber(List<int> sequence)
        {
            if (sequence.Count < 2)
            {
                Console.WriteLine("A sequência deve ter pelo menos dois elementos para prever o próximo número.");
                return;
            }

            Console.WriteLine($"Sequência atual: {string.Join(", ", sequence)}");

            int nextNumber = PredictNextNumber(sequence);

            Console.WriteLine($"Próximo número na sequência: {nextNumber}\n");
        }

        private int PredictNextNumber(List<int> sequence)
        {
            if (IsArithmeticProgression(sequence))
            {
                return PredictNextArithmeticNumber(sequence);
            }
            else if (IsGeometricProgression(sequence))
            {
                return PredictNextGeometricNumber(sequence);
            }
            else if (IsSquareOfArithmeticProgression(sequence))
            {
                return PredictNextNumberFromSquareOfArithmeticProgression(sequence);
            }
            else if (IsFibonacciSequence(sequence))
            {
                return PredictNextFibonacciNumber(sequence);
            }
            else
            {
                Console.WriteLine("Padrão não identificado. Usando a média como previsão.");
                return (int)Math.Round(sequence.Average());
            }
        }

        private bool IsArithmeticProgression(List<int> sequence)
        {
            int diff = sequence[1] - sequence[0];
            for (int i = 2; i < sequence.Count; i++)
            {
                if (sequence[i] - sequence[i - 1] != diff)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsGeometricProgression(List<int> sequence)
        {
            if (sequence[0] == 0)
            {
                return false;
            }

            int ratio = sequence[1] / sequence[0];
            for (int i = 2; i < sequence.Count; i++)
            {
                if (sequence[i] / sequence[i - 1] != ratio)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsSquareOfArithmeticProgression(List<int> sequence)
        {
            // Check if the sequence has at least three elements
            if (sequence.Count < 3)
            {
                return false;
            }

            // Calculate the square roots of the numbers in the sequence
            List<int> squareRoots = sequence.Select(n => (int)Math.Sqrt(n)).ToList();

            // Check if the square roots form an arithmetic progression
            int diff = squareRoots[1] - squareRoots[0];
            for (int i = 2; i < squareRoots.Count; i++)
            {
                if (squareRoots[i] - squareRoots[i - 1] != diff)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsFibonacciSequence(List<int> sequence)
        {
            for (int i = 2; i < sequence.Count; i++)
            {
                if (sequence[i - 2] + sequence[i - 1] != sequence[i])
                {
                    return false;
                }
            }
            return true;
        }

        private int PredictNextArithmeticNumber(List<int> sequence)
        {
            int diff = sequence[1] - sequence[0];
            return sequence.LastOrDefault() + diff;
        }

        private int PredictNextGeometricNumber(List<int> sequence)
        {
            int ratio = sequence[1] / sequence[0];
            return sequence.LastOrDefault() * ratio;
        }

        private int PredictNextNumberFromSquareOfArithmeticProgression(List<int> sequence)
        {
            if (sequence.Count < 2)
            {
                Console.WriteLine("A sequência deve ter pelo menos dois elementos para prever o próximo número.");
                return 0;
            }

            // Calcula a raiz quadrada dos elementos da sequência
            List<int> squareRoots = sequence.Select(x => (int)Math.Sqrt(x)).ToList();

            // Verifica a diferença entre os elementos consecutivos da sequência de raízes quadradas
            int diff = squareRoots[1] - squareRoots[0];
            for (int i = 2; i < squareRoots.Count; i++)
            {
                if (squareRoots[i] - squareRoots[i - 1] != diff)
                {
                    Console.WriteLine("Padrão não identificado. Usando a média como previsão.");
                    return (int)Math.Round(sequence.Average());
                }
            }

            // Calcula o próximo termo na sequência de raízes quadradas
            int nextRoot = squareRoots.LastOrDefault() + diff;

            // Eleva ao quadrado o próximo termo para obter o próximo número na sequência de quadrados
            int nextSquare = nextRoot * nextRoot;

            return nextSquare;
        }

        private int PredictNextFibonacciNumber(List<int> sequence)
        {
            return sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
        }

        private bool IsPerfectSquare(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }
    }
}