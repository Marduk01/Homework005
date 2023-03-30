// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив : ");
PrintArray(numbers);

int sum = 0;

for (int i = 1; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
}

Console.Write($" {numbers.Length} чисел, сумма элементов массива на нечетных позициях {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
}