﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = numbers.Where(s => s % 2 == 0);

foreach (var evenNumber in evenNumbers)
{
    Console.WriteLine(evenNumber);
}

Console.WriteLine("Select Example:");


var squares = numbers.Select(s => s * s);
foreach (var square in squares)
{
    Console.WriteLine(square);
}
Console.WriteLine("Aggregate example:");
var total = numbers.Aggregate((total, number) => total + number);
Console.WriteLine(total);

List<string> letters = new List<string> { "Mahmut", "Mesut", "Ömer", "İbrahim" };
var result = letters.Aggregate((a, b) => a + " " + b);
Console.WriteLine(result);