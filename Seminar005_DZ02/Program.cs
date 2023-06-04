// Задача 36: Задайте одномерный массив, заполненный
//  случайными числами. Найдите сумму элементов, 
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.Write("Массив = ");
PrintArray(numbers);
void RandonNumbers(int[] numbers)
{
    {
        for(int i = 0; i < size; i++)
        {
            numbers[i] = new Random().Next(0,101);
        }
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 1)
            sum = sum + numbers[i];
        }
        Console.WriteLine($"Сумма числел на нечетных ячейках массива = [ {sum} ]");
    }
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