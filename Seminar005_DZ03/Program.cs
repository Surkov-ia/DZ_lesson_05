// Задача 38: Задайте массив вещественных чисел. работает
//  Найдите разницу между максимальным и минимальным
//   элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] 
// => 77.15 - 1.15 = 76

Console.Write("Введите длину массива = ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
RandonNumbers(numbers);
Power(numbers);
Console.Write("Массив = ");
PrintArray(numbers);
void RandonNumbers(double[] numbers)
{
    
    for(int i = 0; i < size; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1,100) / 1.3);
    }
}
void Power(double[] numbers)
{
    double max = 0;
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            {
                max = numbers[i];
            }
        if (numbers[i] < min)
            {
                min = numbers[i];
            }
    } 
    Console.WriteLine($"максимальное значение = [ {Math.Round(max, 2)} ]");
    Console.WriteLine($"Минимальное значение  = [ {Math.Round(min, 2)} ]");
    Console.WriteLine($"Разница между значениями = [ {Math.Round(Math.Round(max, 2) - Math.Round(min, 2), 2)} ]");
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(Math.Round(numbers[i], 2)+ " ");
    }
    Console.Write("]");
    Console.WriteLine();
}