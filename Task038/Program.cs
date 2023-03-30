// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

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

Console.WriteLine($"Всего чисел : {numbers.Length}. Максимальное значение : {max}, минимальное значение : {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением : {max - min} ");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void PrintArray(double[] numbers)
{
    for (int j = 0; j < numbers.Length; j++) 
    {
        Console.WriteLine();
    }
}