// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = numbers.Where(s => s % 2 == 0);

foreach (var evenNumber in evenNumbers)
{
    Console.WriteLine(evenNumber);
}