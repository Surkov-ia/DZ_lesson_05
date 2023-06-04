﻿// Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет
//   количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите длину массива = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

RandonNumbers(numbers);
Power(numbers);
Console.Write("Массив = ");
PrintArray(numbers);
void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void Power(int[] numbers)
{
    int count = 0;

    for (int x = 0; x < numbers.Length; x++)
    {
        if (numbers[x] % 2 == 0)
        count++;
    }
    Console.WriteLine($"из [ {numbers.Length} ] чисел, [ {count} ] четных");
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}