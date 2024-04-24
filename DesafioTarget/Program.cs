using DesafioTarget.Models;

Console.WriteLine("Desafio 1:");
Challange1 challenge1 = new Challange1();

challenge1.Sum();

Console.WriteLine("\nDesafio 2:");
Challange2 challenge2 = new Challange2();

int number = 21;

challenge2.CheckFibonacciSequence(number);


Console.WriteLine("\nDesafio 3:");
List<int> sequence1 = new List<int>() { 1, 3, 5, 7 };
List<int> sequence2 = new List<int>() { 2, 4, 8, 16, 32, 64 };
List<int> sequence3 = new List<int>() { 0, 1, 4, 9, 16, 25, 36 };
List<int> sequence4 = new List<int>() { 4, 16, 36, 64 };
List<int> sequence5 = new List<int>() { 1, 1, 2, 3, 5, 8 };

Challange3 solver = new Challange3();

solver.PredictAndPrintNextNumber(sequence1);
solver.PredictAndPrintNextNumber(sequence2);
solver.PredictAndPrintNextNumber(sequence3);
solver.PredictAndPrintNextNumber(sequence4);
solver.PredictAndPrintNextNumber(sequence5);

Console.WriteLine("\nDesafio 5:");
Challange5 challange5 = new Challange5();

string inputString = "Hello, world!";

string invertedString = challange5.InvertString(inputString);

Console.WriteLine($"String original: {inputString}");
Console.WriteLine($"String invertida: {invertedString}");
