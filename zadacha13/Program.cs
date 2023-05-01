// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

int division = number % 1000 / 100;

if (number < 100)

{
    Console.WriteLine("Третьей цифры нет");}

else 

{ 
    
    Console.WriteLine(division);

}
