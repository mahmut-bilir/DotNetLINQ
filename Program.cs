// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = numbers.Where(s => s % 2 == 0);

foreach (var evenNumber in evenNumbers)
{
    Console.WriteLine(evenNumber);
}

Console.WriteLine("Select Example:");

List<int> numbersForSelect = new List<int> { 1, 2, 3, 4, 5 };
var squares = numbersForSelect.Select(s => s * s);
foreach (var square in squares)
{
    Console.WriteLine(square);
}